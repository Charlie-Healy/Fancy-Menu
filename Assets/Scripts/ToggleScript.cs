using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Toggle AudioToggle;
    public GameObject Adjusts;
    void Update()
    {
        
    }

    public void OnClick()
    {
        
        if (AudioToggle.isOn)
        {
            Adjusts.SetActive(true);
            Debug.Log("on");
        }
        else
        {
            Adjusts.SetActive(false);
            Debug.Log("off");
        }
    }
}
