using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    bool isPaused = false;
    public GameObject pauseGameMenu;
    public AudioSource click;
    public AudioSource escape;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !DoorScript.blockEscape)
        {
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
        Cursor.visible = false;

        Camera.main.GetComponent<CameraTurning>().enabled = true;
        Camera.main.GetComponent<AudioSource>().enabled = true;

    }

}

