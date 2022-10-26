using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDetection : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Input.acceleration;

        Debug.Log(dir.ToString());

    }
}
