using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDuplicator : MonoBehaviour
{
    public GameObject objectToDuplicate;
    public int numberOfRows = 20;
    public int numberOfColumns = 20;
    public float spacing = 40f;

    void Start()
    {
        if (objectToDuplicate == null)
        {
            Debug.LogError("Object to duplicate is not set!");
            return;
        }

        Vector3 originalPosition = transform.position;
        Quaternion originalRotation = transform.rotation;

        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfColumns; col++)
            {
                Vector3 offset = new Vector3(col * spacing, 0f, row * spacing);
                Vector3 newPosition = originalPosition + offset;
                GameObject duplicate = Instantiate(objectToDuplicate, newPosition, originalRotation, transform);
            }
        }
    }
}
