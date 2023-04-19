using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowCube : MonoBehaviour
{
    private Material material; // The material of the object that will glow
    private Color originalColor; // The original color of the material
    private Color glowColor = Color.red; // The color to use for the glow
    private bool isColliding = false; // Whether the object is currently colliding with another object

    void Start()
    {
        // Get the material of the object
        material = GetComponent<Renderer>().material;

        // Save the original color of the material
        originalColor = material.color;
        material.color = glowColor;
    }

    void Update()
    {
        // If the object is colliding with another object
        if (isColliding)
        {
            // Set the material color to the glow color
            material.color = glowColor;
        }
        else
        {
            // Set the material color back to the original color
            material.color = originalColor;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Set isColliding to true when the object collides with another object
        isColliding = true;
    }

    void OnCollisionExit(Collision collision)
    {
        // Set isColliding back to false when the object is no longer colliding with another object
        isColliding = false;
    }
}
