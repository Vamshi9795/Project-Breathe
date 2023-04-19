using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseFromGround : MonoBehaviour
{
    public float minY = 0f; // minimum Y value
    public float maxY = 5f; // maximum Y value
    public float speed = 1f; // movement speed

    private bool movingUp = true; // flag to indicate if object is moving up

    private void Update()
    {
        bool allPuzzleChecked = true;

        GameObject[] puzzles = GameObject.FindGameObjectsWithTag("Puzzle");

        // Iterate through the array and check the material color of each object
        foreach (GameObject puzzle in puzzles)
        {
            Renderer renderer = puzzle.GetComponent<Renderer>();
            Material material = renderer.material;
            Color materialColor = material.color;

            if (puzzle.gameObject.GetComponent<Renderer>().material.color != Color.green)
            {
                allPuzzleChecked = false;
            }
        }
        // Move object up or down depending on its current direction
        if (movingUp && allPuzzleChecked)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            if (transform.position.y >= maxY)
            {
                movingUp = false;
            }
        }
    }
}