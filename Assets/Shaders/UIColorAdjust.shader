Shader "Unlit/ColorAdjust"
{
    Properties
    {
        [PerRendererData] _MainTex ("Base (RGB)", 2D) = "white" {}
        _Brightness ("Brightness", Range(-0.25, 0.25)) = 0
        _Contrast("Contrast", Range(0.5, 2)) = 1
        _Saturation("Saturation", Range(0, 2)) = 1
        _Color ("Tint", Color) = (1,1,1,1)

        _StencilComp ("Stencil Comparison", Float) = 8
        _Stencil ("Stencil ID", Float) = 0
        _StencilOp ("Stencil Operation", Float) = 0
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        _StencilReadMask ("Stencil Read Mask", Float) = 255

        _ColorMask ("Color Mask", Float) = 15

        [Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
    }
    SubShader
    {
        Tags
        {
            "Queue"="Transparent"
            "IgnoreProjector"="True"
            "RenderType"="Transparent"
            "PreviewType"="Plane"
            "CanUseSpriteAtlas"="True"
        }

        Stencil
        {
            Ref [_Stencil]
            Comp [_StencilComp]
            Pass [_StencilOp]
            ReadMask [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }

        Cull Off
        Lighting Off
        ZWrite Off
        ZTest [unity_GUIZTestMode]
        Blend SrcAlpha OneMinusSrcAlpha
        ColorMask [_ColorMask]
        
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 2.0

            #include "UnityCG.cginc"
            #include "UnityUI.cginc"

            #pragma multi_compile_local _ UNITY_UI_CLIP_RECT
            #pragma multi_compile_local _ UNITY_UI_ALPHACLIP
            
            struct appdata_t
            {
                half4 vertex : POSITION;
                half4 color : COLOR;
                half2 texcoord : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };
            struct v2f
            {
                half4 vertex : SV_POSITION;
                half4 color : COLOR;
                half2 texcoord : TEXCOORD0;
                half4 worldPosition : TEXCOORD1;
                UNITY_VERTEX_OUTPUT_STEREO
            };
            
            sampler2D _MainTex;
            half4 _MainTex_ST;
            half _Brightness;
            half _Contrast;
            half _Saturation;
            half4 _Color;

            half4 _TextureSampleAdd;
            float4 _ClipRect;
            
            v2f vert (appdata_t v)
            {
                v2f OUT;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
                OUT.worldPosition = v.vertex;
                OUT.vertex = UnityObjectToClipPos(OUT.worldPosition);
                OUT.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                OUT.color = v.color * _Color;
                return OUT;
            }
            
            inline half4 applyHSBEffect(half4 startColor)
            {
                half4 outputColor = startColor;
                outputColor.rgb = (outputColor.rgb - 0.5f) * (_Contrast)+0.5f;
                outputColor.rgb = outputColor.rgb + _Brightness;
                half3 intensity = dot(outputColor.rgb, half3(0.299, 0.587, 0.114));
                outputColor.rgb = lerp(intensity, outputColor.rgb, _Saturation);
                return outputColor;
            }
            
            fixed4 frag (v2f IN) : SV_Target
            {
                half4 startColor = tex2D(_MainTex, IN.texcoord) * IN.color;
                half4 hsbColor = applyHSBEffect(startColor);

                #ifdef UNITY_UI_CLIP_RECT
                hsbColor.a *= UnityGet2DClipping(IN.worldPosition.xy, _ClipRect);
                #endif

                #ifdef UNITY_UI_ALPHACLIP
                clip (hsbColor.a - 0.001);
                #endif
                
                return hsbColor;
            }
            ENDCG
        }
    }
}