using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class TomatoCollector : MonoBehaviour {

    int tomatototal = 0;
    public Rigidbody rb;

    public Text printmoney;


    int tomatomoney = 0;


    //public int timeLeft = 120;
    //public Text countdownText;
    //public GameObject Timer;

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Tomato")
        {
            tomatototal++;
            GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log(tomatototal);
            GameObject.FindObjectOfType<Timer>().StartTimer ();
        }
    }


    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Tomato")
        {
            tomatototal--;
        }
    }

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
   
    }


    public void moneytoprint()
    {


        if (tomatototal <= 10)
        {
            tomatomoney = Random.Range(5, 20);
        }

        if (tomatototal >= 11)
        {
            tomatomoney = Random.Range(20, 40);
        }

        printmoney.text = tomatomoney.ToString();
    }
}
