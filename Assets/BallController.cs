using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float moveForce = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
        rb.AddForce(movement * moveForce);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 contactPoint = collision.GetContact(0).point;
        Vector3 normal = collision.GetContact(0).normal;
        Vector3 newDirection = Vector3.Reflect(rb.velocity, normal);

        rb.velocity = newDirection;
    }
}
