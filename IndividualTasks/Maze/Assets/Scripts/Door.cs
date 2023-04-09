using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject unlocked;
    public GameObject locked;
    public GameObject door;
    public AudioSource audioSource;
    public AudioSource buttonClicked;
    public bool isLocked = true;
    public bool isOver = false;
    public static bool blockEscape = false;
    public Timer timer;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (!isLocked && (Input.GetMouseButton(0)))
            {
                door.SetActive(false);
                audioSource.Play();
                isLocked = false;
                blockEscape = true;
                isOver = true;
                timer.StopTime(isOver);
                ActivateGameOver();
                unlocked.SetActive(false);

            }
            else if (!isLocked)
            {
                unlocked.SetActive(true);
            }
            else
            {
                locked.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            locked.SetActive(false);
            unlocked.SetActive(false);
        }
    }

    void ActivateGameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOver.SetActive(true);
    }

    public void RestartGame()
    {
        buttonClicked.Play();
        blockEscape = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        buttonClicked.Play();
        SceneManager.LoadScene("GameMenu");
    }
    public void Unlock()
    {
        isLocked = false;
    }

}
