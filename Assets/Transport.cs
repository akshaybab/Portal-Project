using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController Controller; 
    public Transform Player;
    public Transform otherPortal;
    public bool InPortal;  

    public Vector3 ExitSpeed;

    public Vector3 correction; 
    // Update is called once per frame
    void Update()
    {
        if (InPortal) {
            ExitSpeed = Controller.velocity; 
            Vector3 portalToPlayer = Player.position - transform.position; 

            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            Debug.Log(dotProduct);
            if (dotProduct < 0f) {
                Controller.enabled = false; 
                Player.position = otherPortal.position + correction;
                Controller.enabled = true; 
                InPortal = false; 
                Debug.Log("Moved player");
                Debug.Log(Player.position);

            }
        }
    }   

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            Debug.Log("Enter");
            InPortal = true; 
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("Exit");
            InPortal = false; 
            Vector3 exitVector = Controller.GetComponent<instantPortal>().ExitVector; 
            Controller.Move(exitVector* ExitSpeed.magnitude);
        }
    }
}
