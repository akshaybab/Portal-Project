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
                portal2.GetComponent<Transform>().position = hit.point;
            }
        }
    }
}