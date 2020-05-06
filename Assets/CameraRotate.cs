using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    public Camera view;

    public GameObject Player;  


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorBetween = (view.transform.position - Player.transform.position).normalized; 
        view.transform.rotation = Quaternion.FromToRotation(Vector3.right, -1 * vectorBetween);
    }
}
