using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleManager : MonoBehaviour
{
    public Toggle Checkmark;
   
   

    private void Update()
    {
        ActiveToggle();
    }
    public void ActiveToggle()
    {
        if(Checkmark.enabled)
        {
            Debug.Log("English language is selected");
        }
    }
   
  
}
