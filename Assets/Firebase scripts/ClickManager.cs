using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;


public class ClickManager : MonoBehaviour
{
    [SerializeField]
    private Button HomeBottomPanelCamera;
    [SerializeField]
    private Button HomeBottomPanelTrending;
    [SerializeField]
    private Button HomeBottomPanelGallery; 
    [SerializeField]
    private Button TopBarSetting; 
    // Start is called before the first frame update
    void Start()
    {
        HomeBottomPanelCamera.onClick.AddListener(() => Clicked("Camera"));
        HomeBottomPanelTrending.onClick.AddListener(() => Clicked("Trending"));
        HomeBottomPanelGallery.onClick.AddListener(() => Clicked("Gallery"));
        TopBarSetting.onClick.AddListener(() => Clicked("Setting"));
    }

    private void Clicked(string name)
    {
        Debug.Log(name + " button was clicked");
    }
}
