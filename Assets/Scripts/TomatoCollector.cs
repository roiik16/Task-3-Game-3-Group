using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoCollector : MonoBehaviour {

    int tomatototal = 0;


    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Tomato")
        {
            tomatototal++;

            Debug.Log(tomatototal);
        }
    }


    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Tomato")
        {
            tomatototal--;

            Debug.Log(tomatototal);
        }
    }

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
