using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour
{
    HoverOverIndicator HoverScript;
    GameObject XObject;
    Transform explodePos;
    public GameObject[] pieces; // The array of pieces to be spawned
    public float explosionForce = 2f; // The force applied to the pieces
    public float explosionRadius = 0.5f; // The radius of the explosion
    public AudioClip mySound;
    // Start is called before the first frame update
    void Start()
    {
       HoverScript = GetComponent<HoverOverIndicator>(); 
       XObject = GameObject.Find("co21parent");
        GameObject piece1 = GameObject.Find("original");
        pieces = new GameObject[] { piece1};   


    }
    void Update()
    {
        if (HoverScript.controllpointing())
        {
            
            if (CAVE2.GetButtonDown(CAVE2.Button.Button3))
            {
                 
              {
                    
                    GameObject[] elements = GameObject.FindGameObjectsWithTag("Explosive");
                    // loop through all CO2 objects
                    foreach (GameObject element in elements) {
                        // Loop through the array of pieces to be spawned
                        foreach (GameObject piece in pieces)
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                // Spawn a piece at the object's position with a random rotation
                                GameObject newPiece = Instantiate(piece, element.transform.position, Random.rotation);

                                // Add force to the piece in a random direction
                                newPiece.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * explosionForce, ForceMode.Impulse);
                            }
                        }
                        Destroy(element);
                    }
                    GetComponent<AudioSource>().PlayOneShot(mySound);
                }
            }
        }
    }
}
