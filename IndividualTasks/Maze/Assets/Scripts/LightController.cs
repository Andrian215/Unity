using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public AudioSource flashlight;
    public Light spotlight;

    void ToggleLight()
    {
        spotlight.enabled = !spotlight.enabled;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ToggleLight();
            flashlight.Play();
        }
    }
}

