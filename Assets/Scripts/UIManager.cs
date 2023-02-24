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
    //Panels
    [SerializeField]
    private GameObject CameraPanel;
    [SerializeField]
    private GameObject HomePanel;

  
 
    void Start()
    {
        HomeBottomPanelCamera.onClick.AddListener(CameraPanelActive);   
        HomeBottomPanelTrending.onClick.AddListener(CameraPanelActive);
        HomeBottomPanelGallery.onClick.AddListener(CameraPanelActive);
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
}