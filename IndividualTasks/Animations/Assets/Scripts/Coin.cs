using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coin;
    void OnTriggerEnter(Collider other)
    {
        coin.Play();
        Destroy(gameObject);
    }
}
