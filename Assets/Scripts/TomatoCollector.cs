using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TomatoCollector : MonoBehaviour {

    int tomatototal = 0;
    public Rigidbody rb;
    //  public int timeLeft = 120;
    //public Text countdownText;
    //public GameObject Timer;

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Tomato")
        {
            print("hi");
            tomatototal++;
            rb.isKinematic = false;
            Debug.Log(tomatototal);
            GameObject.FindObjectOfType<Timer>().StartTimer ();
            
            
            //Start the timer
            //StartCoroutine("LoseTime");
            //Timer.SetActive(true);
            //CountDown


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
        //Timer.SetActive(true);
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    
}
