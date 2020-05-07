using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour
{
    public Rigidbody projectileObject;
    public Transform barrelEnd;
    
    
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(projectileObject, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 1000);
        }
    }
}