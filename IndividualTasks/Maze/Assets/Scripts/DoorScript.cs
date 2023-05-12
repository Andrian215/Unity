using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public GameObject gameOver;
    public Animator doorAnim;
    private bool isOpened = false;
    public AudioSource doorOpened;
    public AudioSource doorClosed;
    public static bool blockEscape = false;

    void Start()
    {
        blockEscape = default;
        doorAnim = GetComponent<Animator>();
    }

    public void Door()
    {
        if (!isOpened)
        {
            doorAnim.SetBool("isOpen", true);
            isOpened = true;
            doorOpened.Play();
        }
        else
        {
            doorAnim.SetBool("isOpen", false);
            isOpened = false;
            doorClosed.Play();
        }
    }

    public void Locked()
    {
        doorAnim.SetBool("isOpen", true);
        doorOpened.Play();
        blockEscape = true;
        Timer.gameOver = true;
        ActivateGameOver();
    }

    private void ActivateGameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOver.SetActive(true);
    }
}
