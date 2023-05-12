using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public AudioSource click;

    public void StartGame()
    {
        click.Play();
        Cursor.visible = false;
        SceneManager.LoadScene("GameScene");

    }

    public void ExitGame()
    {
        click.Play();
        Application.Quit();
    }

}
