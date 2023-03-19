using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over!"); 
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1.0f;
        }
    }
}

