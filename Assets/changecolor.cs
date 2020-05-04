using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
	Color orange = new Color(0.2F, 0.3F, 0.4F);
    // Start is called before the first frame ;update
    void Start(){
		GetComponent<Renderer>().material.color = orange;
		GetComponent<TextMesh>().fontStyle = FontStyle.Normal;
	}

	void OnMouseEnter(){
		GetComponent<Renderer>().material.color = Color.blue;
		GetComponent<TextMesh>().fontStyle = FontStyle.Bold;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = orange;
		GetComponent<TextMesh>().fontStyle = FontStyle.Normal;
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
