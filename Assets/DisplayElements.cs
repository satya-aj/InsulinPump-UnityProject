using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayElements : MonoBehaviour
{
    public TextMesh textMesh;
    public Transform cylinder;
    // Start is called before the first frame update
    void Start()
    {
        // Get the TextMeshPro component
        textMesh = GetComponent<TextMesh>();

        // Ensure the TextMeshPro and cylinder objects are assigned in the Inspector
        if (textMesh == null || cylinder == null)
        {
            Debug.LogError("TextMeshPro or cylinder object not assigned.");
            return;
        }

        // Position the text on the cylinder
        PositionTextOnCylinder();
    }

    void PositionTextOnCylinder()
    {
        // Calculate the position and rotation for the text
        Vector3 midpoint = (cylinder.transform.position + transform.position) / 2f;
        Vector3 direction = (transform.position - cylinder.transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Set the text's position and rotation
        transform.position = midpoint;
        transform.rotation = rotation;
    }
}
