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
    private Button HomeTopBarSetting;
    [SerializeField]
    private Button BackCamera;
    [SerializeField]
    private Button CameraPro;
    [SerializeField]
    private Button ProExit;
    [SerializeField]
    private Button BackSetting;
    [SerializeField]
    private Button GalleryPanelHome;
    [SerializeField]
    private Button SettingLanguage;
    [SerializeField]
    private Button LanguageTopBarTick;
    //Panels
    [SerializeField]
    private GameObject CameraPanel;
    [SerializeField]
    private GameObject HomePanel;
    [SerializeField]
    private GameObject GalleryPanel;
    [SerializeField]
    private GameObject SettingPanel;
    [SerializeField]
    private GameObject SettingLanguagePanel;
    [SerializeField]
    private GameObject CameraProPanel;

  
 
    void Start()
    {
        HomePanel.SetActive(true);
        HomeBottomPanelCamera.onClick.AddListener(CameraPanelActive);   
        GalleryPanelHome.onClick.AddListener(HomePanelActive);
        HomeBottomPanelGallery.onClick.AddListener(GalleryPanelActive);
        HomeTopBarSetting.onClick.AddListener(SettingPanelActive);
        BackCamera.onClick.AddListener(BackButton);
        BackSetting.onClick.AddListener(BackButton);
        SettingLanguage.onClick.AddListener(LanguagePanelActive);
        LanguageTopBarTick.onClick.AddListener(HomePanelActive);
        CameraPro.onClick.AddListener(CameraProPanelActive);
        ProExit.onClick.AddListener(CameraPanelActive);
    }

    private void CameraPanelActive()
    {
        CameraPanel.SetActive(true);
        HomePanel.SetActive(false);
        CameraProPanel.SetActive(false);
        Debug.Log("Camera button was clicked");
        
        FirebaseManager.instance.LogEvent(name);
    }  
    private void CameraProPanelActive()
    {
        CameraProPanel.SetActive(true);
        CameraPanel.SetActive(false);
    }
   
  
    private void BackButton()
    {
        HomePanel.SetActive(true);
        CameraPanel.SetActive(false);
        SettingPanel.SetActive(false);
        Debug.Log("Back Button was clicked");
    }
    private void HomePanelActive()
    {
        HomePanel.SetActive(true);
        GalleryPanel.SetActive(false);
        SettingLanguagePanel.SetActive(false);
        Debug.Log("Gallery Home button was Clicked");
    }
    private void GalleryPanelActive()
    {
        GalleryPanel.SetActive(true);
        HomePanel.SetActive(false);
    }
    private void SettingPanelActive()
    {
        SettingPanel.SetActive(true);
        HomePanel.SetActive(false);
    }
    private void LanguagePanelActive()
    {
        SettingLanguagePanel.SetActive(true);
        SettingPanel.SetActive(false);
    }
}