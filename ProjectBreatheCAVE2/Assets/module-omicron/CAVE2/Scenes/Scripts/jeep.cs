using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeep : MonoBehaviour
{
    public Transform targetPosition;
    public float speed;
    public GameObject cam;
    public Transform triggerPos; // position that trigger car movement

    private void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    void Update()
    {
        if (cam.transform.position.z > triggerPos.position.z) {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, step);
        }
    }
}
  