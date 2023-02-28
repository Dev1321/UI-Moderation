using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Togglemanager : MonoBehaviour
{
    public Toggle English;
    public Toggle Hindi;
    public Toggle Portugese;
    public Toggle Spanish;
    public Toggle Indonesian;
    // Update is called once per frame
    void Update()
    {
        ToggleActivate();
    }
    public void ToggleActivate()
    {
        if (English.isOn)
        {
            Debug.Log("English language is selected");
        }
        else if (Hindi.isOn)
        {
            Debug.Log("Hindi Language is selected");
        }
        else if(Portugese.isOn)
        { 
            Debug.Log("Portugese language is selected");
        }
        else if(Spanish.isOn)
        {
            Debug.Log("Spanish language is selected");
        }
        else if(Indonesian.isOn)
        {
            Debug.Log("Indonesian language is selected");
        }
    }
}