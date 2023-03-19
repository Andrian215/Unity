using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float moveRadius = 10f;

    private float timeCounter = 0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        timeCounter += Time.deltaTime;

        float x = Mathf.Sin(timeCounter * moveSpeed) * moveRadius;
        Vector3 newPosition = startPosition + new Vector3(x, 0f, 0f);

        transform.position = newPosition;
    }
}
