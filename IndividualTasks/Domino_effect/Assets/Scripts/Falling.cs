using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Rigidbody rb;

    public float initialVelocity = 3f;
    public float dominoAngularDrag = 0.1f;

    private bool dominoIsMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularDrag = dominoAngularDrag;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !dominoIsMoving)
        {
            dominoIsMoving = true;
            rb.velocity = -transform.right * initialVelocity;
        }
    }
}

