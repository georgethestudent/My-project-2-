using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotiere den Cube um die z-Achse basierend auf der rotationSpeed und der Zeit seit dem letzten Frame
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
