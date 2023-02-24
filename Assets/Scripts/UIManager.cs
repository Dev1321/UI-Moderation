using UnityEngine;
using UnityEngine.UI;
using Firebase.Analytics;
using System;

public class UIManager : MonoBehaviour
{
    //Buttons
    [SerializeField]
    private Button HomeBottomPanelCamera;
    [SerializeField]
    private Button HomeBottomPanelTrending;
    [SerializeField]
    private Button HomeBottomPanelGallery; 
    [SerializeField]
    private Button TopBarSetting;
    [SerializeField]
    private Button Back;
    [SerializeField]
    private Button GalleryPanelHome;
    //Panels
    [SerializeField]
    private GameObject CameraPanel;
    [SerializeField]
    private GameObject HomePanel;
    [SerializeField]
    private GameObject GalleryPanel;

  
 
    void Start()
    {
        HomeBottomPanelCamera.onClick.AddListener(CameraPanelActive);   
        GalleryPanelHome.onClick.AddListener(HomePanelActive);
        HomeBottomPanelGallery.onClick.AddListener(GalleryPanelActive);
        TopBarSetting.onClick.AddListener(CameraPanelActive);
        Back.onClick.AddListener(BackButton);
    }
    private void CameraPanelActive()
    {
        CameraPanel.SetActive(true);
        HomePanel.SetActive(false);
        Debug.Log(name + " button was clicked");
        FirebaseManager.instance.LogEvent(name);
    }  
    private void BackButton()
    {
        HomePanel.SetActive(true);
        CameraPanel.SetActive(false);
        Debug.Log("Back Button was clicked");
    }
    private void HomePanelActive()
    {
        HomePanel.SetActive(true);
        GalleryPanel.SetActive(false);
        Debug.Log("Gallery Home button was Clicked");
    }
    private void GalleryPanelActive()
    {
        GalleryPanel.SetActive(true);
        HomePanel.SetActive(false);
    }
}