using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door;
    public GameObject button;
    private Animator buttonAnim;

    void Start()
    {
        buttonAnim = GetComponent<Animator>();
    }

    public void Unlock()
    {
        if (Item.hasKey)
        {
            buttonAnim.SetTrigger("isButton");
            door.GetComponent<DoorScript>().Locked();
            button.GetComponent<Renderer>().material.color = Color.green;
            Item.hasKey = !Item.hasKey;
            Interaction.blocked = true;
        }
    }
}
