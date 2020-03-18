using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Transform PortalTwo;

    public Collider Wall; 
    public bool InPortal;  

    // Update is called once per frame
    void Update()
    {
        if (InPortal) {
            Vector3 portalToPlayer = Player.position - transform.position; 

            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            Debug.Log(dotProduct);
            if (dotProduct < 0f) {
                Player.position = PortalTwo.position + new Vector3 (2,2,0); 
            }
        }
    }   

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Environment") {
            Wall = other;
        }
        if (other.tag == "Player") {
            Wall.enabled = false;
            Debug.Log("Enter");       
            InPortal = true; 
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            Wall.enabled = true; 
            Debug.Log("Exit");
            InPortal = false; 
        }
    }
}
