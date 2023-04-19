using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAndDisappear : MonoBehaviour
{
    public GameObject puzzle;
    public GameObject approveText;
    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == puzzle.name)
        {
            Destroy(gameObject); // Activate Object A
            approveText.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
