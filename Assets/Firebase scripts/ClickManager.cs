using UnityEngine;
using UnityEngine.UI;
using Firebase.Analytics;
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
 
    void Start()
    {
        HomeBottomPanelCamera.onClick.AddListener(() => Clicked("Camera"));
        HomeBottomPanelTrending.onClick.AddListener(() => Clicked("Trending"));
        HomeBottomPanelGallery.onClick.AddListener(() => Clicked("Gallery"));
        TopBarSetting.onClick.AddListener(() => { Clicked("Setting"); });
    }

    private void Clicked(string name)
    {
        Debug.Log(name + " button was clicked");
        FirebaseManager.instance.LogEvent(name);
    }  
}