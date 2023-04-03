using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    private AudioSource audioSource;
    public float speed = 10.0f;
    public float boostedSpeed = 25.0f;

    private CharacterController controller;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float currentSpeed = speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = boostedSpeed;
            audioSource.pitch = Mathf.Lerp(audioSource.pitch, 1.0f, Time.deltaTime * 5.0f);
        }
        else
        {
            audioSource.pitch = Mathf.Lerp(audioSource.pitch, 0.6f, Time.deltaTime * 5.0f);
        }


        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += -transform.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += -transform.forward;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right;
        }

        moveDirection = moveDirection.normalized * currentSpeed;

        controller.Move(moveDirection * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}

