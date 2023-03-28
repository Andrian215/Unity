using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 30f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

