using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Image Checkmark;
    int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(index==1)
        {
            Checkmark.gameObject.SetActive(false);
        }
        if(index==0)
        {
            Checkmark.gameObject.SetActive(true);
        }
    }
}
