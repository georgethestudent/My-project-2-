using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referenz auf den Spieler (Player-Character)
    public float offset; // Offset, um die Position der Kamera auf der X-Achse anzupassen

    void LateUpdate()
    {
        // Berechne die Zielposition der Kamera basierend auf dem Spieler und dem Offset auf der X-Achse
        Vector3 targetPosition = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);

        // Aktualisiere die Kamera-Position
        transform.position = targetPosition;
    }
}
