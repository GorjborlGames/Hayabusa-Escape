﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenAttackEnemy : MonoBehaviour {

    private Transform CameraPosition;


	// Use this for initialization
	void Start () {

        CameraPosition = GameObject.FindGameObjectWithTag("MainCamera").transform;

	}
	
	// Update is called once per frame
	void Update () {

        transform.position += new Vector3(-0.5f, 0, 0);

        if (gameObject.transform.position.x < CameraPosition.position.x - 15)
        {
            Destroy(gameObject);
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            Destroy(gameObject);
        }
    }
}
