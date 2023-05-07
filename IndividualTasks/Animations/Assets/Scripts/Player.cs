using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController characterController;

    public float Speed = 6;
    public float RunSpeed = 11;
    public float JumpSpeed = 8;
    public float Gravity = 20;
    private bool isRunning;
    public bool grounded = false;

    public Vector3 moveDirection;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        TryGetComponent(out characterController);
    }

    private void Update()
    {
        Vector2 inputs = Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), 1);
        isRunning = Input.GetKey(KeyCode.LeftShift);

        if (isRunning)
        {
            moveDirection = new Vector3(inputs.x * RunSpeed, moveDirection.y, inputs.y * RunSpeed);
        }
        else
        {
            moveDirection = new Vector3(inputs.x * Speed, moveDirection.y, inputs.y * Speed);
        }

        if (characterController.isGrounded)
        {
            grounded = true;
            moveDirection.y = 0;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = JumpSpeed;
            }
        }
        else
        {
            grounded = false;
        }

        moveDirection.y -= Gravity * Time.deltaTime;
        characterController.Move(transform.TransformVector(moveDirection) * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");

        if (mouseX != 0)
        {
            Vector3 currentRotation = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y + mouseX, currentRotation.z);
        }


    }

}
