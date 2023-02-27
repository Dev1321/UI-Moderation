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
    private Button HomeBottomPanelToGallery; 
    [SerializeField]
    private Button HomeTopBarToSetting;
    [SerializeField]
    private Button BackFromCameraToHome;
    [SerializeField]
    private Button CameraToCameraPro;
    [SerializeField]
    private Button CameraProExit;
    [SerializeField]
    private Button BackFromSettingToHome;
    [SerializeField]
    private Button GalleryPanelToHome;
    [SerializeField]
    private Button GalleryPanelToSetting;
    [SerializeField]
    private Button SettingToLanguage;
    [SerializeField]
    private Button LanguageTickToHome;
    //Panels
    [SerializeField]
    private GameObject CameraPanel, HomePanel, GalleryPanel, SettingPanel, SettingLanguagePanel, CameraProPanel;


    void Start()
    {
        HomePanel.SetActive(true);
        HomePanelToCameraPanel.onClick.AddListener(() => SwitchPanel(HomePanel, CameraPanel));   
        GalleryPanelToHome.onClick.AddListener(() => SwitchPanel(GalleryPanel, HomePanel));
        GalleryPanelToSetting.onClick.AddListener(() => SwitchPanel(GalleryPanel, SettingPanel));
        HomeBottomPanelToGallery.onClick.AddListener(() => SwitchPanel(HomePanel, GalleryPanel));
        HomeTopBarToSetting.onClick.AddListener(() => SwitchPanel(HomePanel, SettingPanel));
        BackFromCameraToHome.onClick.AddListener(() => SwitchPanel(CameraPanel, HomePanel));
        BackFromSettingToHome.onClick.AddListener(() => SwitchPanel(SettingPanel, HomePanel));
        SettingToLanguage.onClick.AddListener(() => SwitchPanel(SettingPanel, SettingLanguagePanel));
        LanguageTickToHome.onClick.AddListener(() => SwitchPanel(SettingLanguagePanel, HomePanel));
        CameraToCameraPro.onClick.AddListener(() => SwitchPanel(CameraPanel, CameraProPanel));
        CameraProExit.onClick.AddListener(() => SwitchPanel(CameraProPanel, CameraPanel));
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

    private  void SwitchPanel(GameObject currentPanelToDeactivate, GameObject newPanelToActivate)
    {
        GameObject currentPanel;
        currentPanel = currentPanelToDeactivate;
        currentPanel.SetActive(false);
        var newPanel = newPanelToActivate;
        newPanel.SetActive(true);
    }
}