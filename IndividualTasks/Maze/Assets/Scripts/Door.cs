using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Key key; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (key.hasKey)
            {
                Destroy(gameObject);
                Debug.Log("Labyrinth completed, Congrats!");
            }
        }
    }
}
