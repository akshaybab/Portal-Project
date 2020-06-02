using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera firstPersonCamera;
    public Camera overheadCamera;
    public GameObject player;
    public GameObject crosshair;
    public GameObject menu;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.SetActive(false);
        crosshair.SetActive(false);

        firstPersonCamera.enabled = false;
    }

    public void clicked()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
        Cursor.visible=false;

        player.SetActive(true);
        crosshair.SetActive(true);
        
        menu.SetActive(false);
    }
    // Update is called once per frame
    /*void play()
    {
        if(Input.GetMouseButtonDown(0)) {
            if (EventSystem.current.IsPointerOverGameObject()){
                clicked();
            }
        }
        //if (event.CurrentSelectedObject == current){
          //  clicked();
        //}
    }*/
    //void Update()
    
       // Cursor.visible = true;
    
}
