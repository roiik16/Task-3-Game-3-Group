﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisbaleFruit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "tomato")
        {
            collision.gameObject.GetComponent<ThrowObjects>().enabled = false;
        }

    }
}
