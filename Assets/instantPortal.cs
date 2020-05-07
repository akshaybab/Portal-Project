using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject portal1;
    public GameObject portal2;
    public GameObject p1;
    public GameObject p2;
    public float count = 0;
    public float count2 = 0;
    
    public Vector3 ExitVector;

    public Transform barrelEnd; 

    public Vector3 wallNormalOne;

    public Vector3 wallNormalTwo;  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (count > 0)
            {
                Destroy(p1);
            }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                count++;
                //p1 = Instantiate(portal1, hit.point, Quaternion.identity);
                //transform.position = hit.point;
                portal1.GetComponent<Transform>().position = hit.point;
                portal1.GetComponent<Transform>().rotation = Quaternion.FromToRotation(Vector3.right , hit.normal);
                Debug.Log(Vector3.forward + " and " + hit.normal);
                wallNormalOne = hit.normal; 

            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (count2 > 0)
            {
                Destroy(p2);
            }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                count2++;
                //p2 = Instantiate(portal2, hit.point, Quaternion.identity);
                Vector3 incomingVec = hit.point - barrelEnd.position;
                ExitVector = Vector3.Reflect(incomingVec, hit.normal);
                portal2.GetComponent<Transform>().position = hit.point;
                portal2.GetComponent<Transform>().rotation = Quaternion.FromToRotation(Vector3.right , hit.normal);
                wallNormalTwo = hit.normal; 
            }
        }
    }
}