using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public CameraScript cameraScript;


    public void SetCameraPosition(int index)
    {
        print("index is " + index);
        cameraScript.SetIndex(index);
    }

    public void SetCameraRotation(int index)
    {
        cameraScript.SetRotIndex(index);
    }

}
