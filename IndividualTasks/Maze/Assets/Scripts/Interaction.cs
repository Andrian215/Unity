using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public Text text;
    private float maxDistance = 10f;
    public static bool blocked = false;
    public static bool stopMob = false;

    void Start()
    {
        stopMob = default;
        blocked = default;
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            if (hit.collider.tag == "key" && !blocked)
            {
                text.enabled = true;
                hit.collider.GetComponent<Item>().Lighting();
                if (Input.GetKeyDown(KeyCode.E))
                {

                    hit.collider.GetComponent<Item>().Interaction();
                }
            }
            else
            {
                text.enabled = false;
            }
            if (hit.collider.tag == "Button" && !blocked)
            {
                text.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<Button>().Unlock();
                    stopMob = true;
                }
            }
            if (hit.collider.tag == "door" && !blocked)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hit.collider.GetComponent<DoorScript>().Door();
                }
            }
        }
        else
        {
            text.enabled = false;
        }
    }
}
