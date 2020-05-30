using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    //public bool isPlay;
    //public bool isQuit;
    public Camera firstPersonCamera;
    public Camera overheadCamera;
    public GameObject player;
    public GameObject crosshair;
    
    void Start()
    {
        //Cursor.visible = true;

        player.SetActive(false);
        crosshair.SetActive(false);

        firstPersonCamera.enabled = false;
    }

    void OnMouseUp()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;

        player.SetActive(true);
        crosshair.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
