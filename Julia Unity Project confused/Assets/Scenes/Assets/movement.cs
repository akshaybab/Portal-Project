using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb; 
    public float speed = 5.0f; 
    // Start is called before the first frame update
    void Start()
    {
        rb =  GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            rb.velocity = transform.right * speed; 
        }
        else if (Input.GetKey(KeyCode.A)) {
            rb.velocity = -transform.right * speed; 
        }
        else if (Input.GetKey(KeyCode.W)) {
            rb.velocity = new Vector3(0,0,1) * speed; 
        }
        else if (Input.GetKey(KeyCode.S)) {
            rb.velocity = new Vector3(0,0,-1) * speed; 
        } 
        else if (Input.GetKey(KeyCode.Space)) {
            
        }


    }
}
