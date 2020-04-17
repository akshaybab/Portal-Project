
using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, 1f);
    }

}
