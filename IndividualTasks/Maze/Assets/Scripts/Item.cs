using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public static bool hasKey = false;
    public Light keyLight;
    public AudioSource keySound;

    public void Lighting()
    {
        keyLight.enabled = true;
    }
    void FixedUpdate()
    {
        keyLight.enabled = false;
    }
    public void Interaction()
    {
        hasKey = true;
        gameObject.SetActive(false);
        keySound.Play();
        GameObject textObject = GameObject.FindGameObjectWithTag("keyFound");
        if (textObject != null)
        {
            TextMeshProUGUI textMeshPro = textObject.GetComponent<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.SetText("Key Found!");
            }
        }
    }
}
