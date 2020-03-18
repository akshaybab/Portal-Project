 using UnityEngine;
using System.Collections;

public class UnityDemo : MonoBehaviour
{
    public float movePace = 10f;
    public float turnPace = 55f;


    //public float jumpForce = 7;
    
    
    void Start ()
    {
        //gameObject.AddComponent<Rigidbody>();
    }
    void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.Translate(Vector3.forward * movePace * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * movePace * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnPace * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnPace * Time.deltaTime);
        }
        //float moveHorizontal = Input.getAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Verticle");
        //Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //if (Input.GetKey(KeyCode.Space))
          //  GetComponent<Rigidbody>().AddForce(Vector3.up * 2000);
    }
}