using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController Controller; 
    public Transform Player;
    public Transform otherPortal;
    public GameObject otherPortObj;
    public bool InPortal;  

    public Transform rotatePlayer; 
    public Vector3 ExitSpeed;
    public Vector3 moveTo;
    // Update is called once per frame
    void Update()
    {
        if (InPortal) {
            ExitSpeed = Controller.velocity; 
            Vector3 portalToPlayer = Player.position - transform.position; 

            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            if (dotProduct < 0f) {
                Controller.enabled = false; 
                //Player.position = otherPortal.position + correction;
                reposition();
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
    void reposition() {
        Vector3 norm;
        if (otherPortObj.name == "Portal") {
            norm = Controller.GetComponent<instantPortal>().normal2;
        }
        else {
            norm = Controller.GetComponent<instantPortal>().normal1;
        }
        float newx = otherPortal.position.x + norm.x;
        float newy = otherPortal.position.y + norm.y;
        float newz = otherPortal.position.z + norm.z;
        Vector3 newP = new Vector3(newx, newy, newz);
        Player.position = newP;
        Player.LookAt(otherPortal);
        Player.Rotate(0F, 180F, 0F, Space.Self);    
    }
}
