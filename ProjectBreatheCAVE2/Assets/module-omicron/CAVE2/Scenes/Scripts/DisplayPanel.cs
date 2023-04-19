using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPanel : MonoBehaviour
{
    GameObject panel;
    private void Start()
    {
        panel = GameObject.Find("EXP");
        panel.SetActive(false);
    }
    private void Update()
    {
        if (GameObject.Find("CAVE2-PlayerController").transform.position.z >= gameObject.transform.position.z)
        {
            panel.SetActive(true);
        }
    }
}
