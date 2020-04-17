using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantPortal : MonoBehaviour
{

    //set portals 1 and 2 before update is called (at the moment they are preset and already present)
    public GameObject portal1;
    public GameObject portal2;

    //how to change angle of rotation
        //find rotation angle of whatever object hit by mouseclick
        //change rotation of this one to that -- use a normal
    void Update() 
    {
        RaycastHit hit;
        //if the keypad/mouse is left clicked
        if (Input.GetMouseButtonDown(0)) 
        {            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                Transform portalTransform = portal1.GetComponent<Transform>();
                
                portalTransform.position = hit.point;
                
                anglePortal(portalTransform, hit);
            }
        }
        //if the keypad/mouse is right clicked 
        else if (Input.GetMouseButtonDown(1)) 
        {            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                Transform portalTransform = portal2.GetComponent<Transform>();

                portalTransform.position = hit.point;
                anglePortal(portalTransform, hit);
            }
        }
    }

    void anglePortal(Transform portalT, RaycastHit hit) 
    {
        Debug.Log(hit.normal);
 
        float xn = hit.point.x + hit.normal.x;
        float yn = hit.point.y + hit.normal.y;
        float zn = hit.point.z + hit.normal.z;

        Vector3 look = new Vector3(xn, yn, zn);
        portalT.LookAt(look);
        portalT.Rotate(0.0f, 90.0f, 0.0f, Space.Self);

    }

}