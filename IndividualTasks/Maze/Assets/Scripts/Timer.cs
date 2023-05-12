using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float startTime;
    public static bool gameOver;

    void Start()
    {
        gameOver = default;
        startTime = Time.time;
    }

    void Update()
    {
        if (!gameOver)
        {
            float elapsedTime = Time.time - startTime;

            int minutes = Mathf.FloorToInt(elapsedTime / 60f);
            int seconds = Mathf.FloorToInt(elapsedTime % 60f);

            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);

            timerText.text = timeString;
        }

    }

}


