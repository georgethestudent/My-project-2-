using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColorChanger : MonoBehaviour
{
    public Material[] materials; // Eine Liste der Materialien mit den gewünschten Farben

    private Renderer rend; // Der Renderer der "Trennwand"

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Wähle eine zufällige Farbe aus dem Materialordner aus
            Material randomMaterial = materials[Random.Range(0, materials.Length)];

            // Ändere das Material der "Trennwand"
            rend.material = randomMaterial;
        }
    }
}
