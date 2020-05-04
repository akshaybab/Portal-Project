using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementsprint : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller; 

    public float speed = 15f; 
    
    public float gravity = -9.8f; 

    public float jumpHeight = 2f; 

    Vector3 downVel; 

    public Transform groundCheck; 

    public float groundDistance = 0.5f; 

    public LayerMask groundMask; 

    bool isGrounded; 

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isGrounded);
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && downVel.y < 0 ) {
            downVel.y = -2f; 
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; 

        if(Input.GetKey(KeyCode.LeftShift)){
            controller.Move(move * speed * Time.deltaTime * 1.5f);
        }
        else{
            controller.Move(move * speed * Time.deltaTime);
        }
//&& is grounded
        if(Input.GetKeyDown(KeyCode.Space)) {
            downVel.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            Debug.Log("Jump");
        }

        downVel.y += gravity * Time.deltaTime; 

        controller.Move(downVel * Time.deltaTime); 


    }

}
