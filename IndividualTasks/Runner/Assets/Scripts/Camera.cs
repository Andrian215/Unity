using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Vector3 offset;

    public GameObject player;
    void Start()
    {
        
    }

    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
    }
}
