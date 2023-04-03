using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera") && Input.GetKeyDown(KeyCode.F))
        {
            Door door = GameObject.FindGameObjectWithTag("door").GetComponent<Door>();
            if (door != null)
            {
                door.Unlock();
                gameObject.SetActive(false);
                if (audioSource)
                {
                    GameObject textObject = GameObject.FindGameObjectWithTag("keyFound");
                    if (textObject != null)
                    {
                        TextMeshProUGUI textMeshPro = textObject.GetComponent<TextMeshProUGUI>();
                        if (textMeshPro != null)
                        {
                            textMeshPro.SetText("Key Found!");
                        }
                    }
                    audioSource.Play();

                }
            }
        }
    }

}

