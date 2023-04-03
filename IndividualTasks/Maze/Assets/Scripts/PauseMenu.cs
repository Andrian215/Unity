using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject pauseGameMenu;
    public AudioSource click;
    public AudioSource escape;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Door.blockEscape)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            escape.Play();
            if (isPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseGameMenu.SetActive(true);
        isPaused = true;

        Camera.main.GetComponent<CameraTurning>().enabled = false;
        Camera.main.GetComponent<AudioSource>().enabled = false;

    }

    public void Resume()
    {
        click.Play();
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        Camera.main.GetComponent<CameraTurning>().enabled = true;
        Camera.main.GetComponent<AudioSource>().enabled = true;

    }


    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }
}

