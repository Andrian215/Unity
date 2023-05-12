using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    bool isPaused;
    public GameObject pauseGameMenu;
    public AudioSource click;
    public AudioSource escape;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !DoorScript.blockEscape)
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
        DoorScript.blockEscape = false;
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        Camera.main.GetComponent<CameraTurning>().enabled = true;
        Camera.main.GetComponent<AudioSource>().enabled = true;

    }

    public void RestartGame()
    {
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        click.Play();
        SceneManager.LoadScene("GameMenu");
    }
}

