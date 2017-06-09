using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EndofDayController : MonoBehaviour {

    public GameObject EndofDay;

	// Use this for initialization
	void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        GameObject.FindObjectOfType<Timer>();
    }
}
