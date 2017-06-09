using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityStandardAssets.Characters.FirstPerson;

public class DisableScripts : MonoBehaviour {

	// Use this for initialization
	public void Start ()
    {
        //GameObject.FindObjectOfType<FirstPersonController>().enabled = false;
    }

	
	// Update is called once per frame
	void Update ()
    {
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tomato")
        {
            collision.gameObject.GetComponent<ThrowObjects>().enabled = false;
        }
    }



}
