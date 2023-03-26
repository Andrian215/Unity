using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public bool hasKey = false;
    private bool isPickedUp = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") && !isPickedUp)
        {
            Debug.Log("Key picked up");
            isPickedUp = true; 
            gameObject.SetActive(false); 
            hasKey = true;
        }
    }

}

