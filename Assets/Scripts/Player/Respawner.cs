using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour {

    public Transform CameraPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(CameraPosition.position.x - 4.35f, CameraPosition.position.y - 3.195001f, 0);

        
		
	}



    
}
