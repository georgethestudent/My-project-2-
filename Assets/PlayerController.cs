using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 30f; // Die Geschwindigkeit des Spielers

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY;
        rb.freezeRotation = true; // Spielerrotation einfrieren
    }

    private void FixedUpdate()
    {
        float horizontalInput = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            horizontalInput = 1f;
        }

        float verticalInput = 0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            verticalInput = -1f;
        }

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * playerSpeed;

        rb.velocity = movement;
    }
}
