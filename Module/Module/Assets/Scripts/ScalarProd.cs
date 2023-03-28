using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalarProd : MonoBehaviour
{
    Vector3 v1 = new Vector3(1, 5, 4);
    Vector3 v2 = new Vector3(2, -2, -6);


    void Start() {
    {
        Vector3 vectorProd = Vector3.Cross(v1, v2);
    }
    }

    void Update()
    {
        float scalarProd = Vector3.Dot(v1, v2);
        Debug.Log("Scalar product of " + v1 + " and " + v2 + " is " + scalarProd);

    }

}

