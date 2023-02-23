using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;


public class ClickManager : MonoBehaviour
{
    public Button Camera;
    // Start is called before the first frame update
    void Start()
    {
        Camera.onClick.AddListener(Clicked); 
    }

    private void Clicked()
    {
        Debug.Log(name + " button was clicked");
    }
}
