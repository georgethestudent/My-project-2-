using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Player; // Der Transform-Komponente des Spielers (Sphere)

    public Vector3 offset; // Der Versatz zwischen der Kamera und dem Spieler

    private void LateUpdate()
    {
        // Aktualisiere die Position der Kamera basierend auf der Position des Spielers
        transform.position = Player.position + offset;
    }
}
