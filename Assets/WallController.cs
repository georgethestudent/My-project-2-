using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float upwardForce = 10f; // Die Kraft, mit der die "Trennwand"-Objekte nach oben bewegt werden

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Bewege die "Trennwand"-Objekte nach oben
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Impulse);
        }
    }
}
