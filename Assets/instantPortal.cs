using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject portal1;
    public GameObject portal2;
    public Vector3 normal1;
    public Vector3 normal2;
    
    public Vector3 ExitVector;

    public Transform barrelEnd; 

    public Vector3 wallNormalOne;

    public Vector3 wallNormalTwo;  
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //p1 = Instantiate(portal1, hit.point, Quaternion.identity);
                //transform.position = hit.point;
                portal1.GetComponent<Transform>().position = hit.point;
                portal1.GetComponent<Transform>().rotation = Quaternion.FromToRotation(Vector3.right , hit.normal);
                Debug.Log(Vector3.forward + " and " + hit.normal);
                wallNormalOne = hit.normal; 
                normal1 = hit.normal;

            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 incomingVec = hit.point - barrelEnd.position;
                ExitVector = Vector3.Reflect(incomingVec, hit.normal);
                portal2.GetComponent<Transform>().position = hit.point;
                portal2.GetComponent<Transform>().rotation = Quaternion.FromToRotation(Vector3.right , hit.normal);
                wallNormalTwo = hit.normal; 
                normal2 = hit.normal;
            }
        }
    }
}