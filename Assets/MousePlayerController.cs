using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePlayerController : MonoBehaviour
{
    public float playerSpeed = 5f; // Die Geschwindigkeit des Spielers

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Ermittle die Position des Mauszeigers in der Weltkoordinate
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = transform.position.y; // Halte die Y-Position des Spielers konstant

        // Berechne die Richtung, in die der Spieler rollen soll
        Vector3 moveDirection = mousePosition - transform.position;
        moveDirection.Normalize(); // Normalisiere die Richtung, um die Geschwindigkeit unabhängig von der Entfernung zu halten

        // Bewege den Spieler in die berechnete Richtung mit der festgelegten Geschwindigkeit
        rb.velocity = moveDirection * playerSpeed;
    }
}
