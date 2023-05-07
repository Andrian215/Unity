using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (firstCamera.enabled)
            {
                firstCamera.enabled = false;
                secondCamera.enabled = true;
            }
            else
            {
                firstCamera.enabled = true;
                secondCamera.enabled = false;
            }
        }
    }
}
