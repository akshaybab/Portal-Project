using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlay;
    //public bool isQuit;
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    
    void Start()
    {
        
    }

    void onMouseUp()
    {
        if(isPlay) {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
