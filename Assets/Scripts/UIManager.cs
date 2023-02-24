using UnityEngine;
using UnityEngine.UI;
using Firebase.Analytics;
using System;

public class UIManager : MonoBehaviour
{
    //Buttons
    [SerializeField]
    private Button HomePanelToCameraPanel;
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
    private GameObject CameraPanel, HomePanel, GalleryPanel, SettingPanel, SettingLanguagePanel, CameraProPanel;


    void Start()
    {
        HomePanel.SetActive(true);
        HomePanelToCameraPanel.onClick.AddListener(() => SwitchPanel(HomePanel, CameraPanel));   
        GalleryPanelHome.onClick.AddListener(() => SwitchPanel(GalleryPanel, HomePanel));
        HomeBottomPanelGallery.onClick.AddListener(() => SwitchPanel(HomePanel, GalleryPanel));
        HomeTopBarSetting.onClick.AddListener(() => SwitchPanel(HomePanel, SettingPanel));
        BackCamera.onClick.AddListener(() => SwitchPanel(CameraPanel, HomePanel));
        BackSetting.onClick.AddListener(() => SwitchPanel(SettingPanel, HomePanel));
        SettingLanguage.onClick.AddListener(() => SwitchPanel(SettingPanel, SettingLanguagePanel));
        LanguageTopBarTick.onClick.AddListener(() => SwitchPanel(SettingLanguagePanel, HomePanel));
        CameraPro.onClick.AddListener(() => SwitchPanel(CameraPanel, CameraProPanel));
        ProExit.onClick.AddListener(() => SwitchPanel(CameraProPanel, CameraPanel));
    }

    //private void CameraPanelActive()
    //{
    //    CameraPanel.SetActive(true);
    //    HomePanel.SetActive(false);
    //    CameraProPanel.SetActive(false);
    //    Debug.Log("Camera button was clicked");
        
    //    FirebaseManager.instance.LogEvent(name);
    //}  
    //private void CameraProPanelActive()
    //{
    //    CameraProPanel.SetActive(true);
    //    CameraPanel.SetActive(false);
    //}

    //private void BackButton()
    //{
    //    HomePanel.SetActive(true);
    //    CameraPanel.SetActive(false);
    //    SettingPanel.SetActive(false);
    //    Debug.Log("Back Button was clicked");
    //}
    //private void HomePanelActive()
    //{
    //    HomePanel.SetActive(true);
    //    GalleryPanel.SetActive(false);
    //    SettingLanguagePanel.SetActive(false);
    //    Debug.Log("Gallery Home button was Clicked");
    //}
    //private void GalleryPanelActive()
    //{
    //    GalleryPanel.SetActive(true);
    //    HomePanel.SetActive(false);
    //}
    //private void SettingPanelActive()
    //{
    //    SettingPanel.SetActive(true);
    //    HomePanel.SetActive(false);
    //}
    //private void LanguagePanelActive()
    //{
    //    SettingLanguagePanel.SetActive(true);
    //    SettingPanel.SetActive(false);
    //}

    private  void SwitchPanel(GameObject deactivate, GameObject activate)
    {
        var currentPanel = deactivate;
        currentPanel.SetActive(false);
        var newPanel = activate;
        newPanel.SetActive(true);
    }
}