using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EndofDayController : MonoBehaviour {


    public GameObject Endofday;
    public GameObject moneytext;

    int familymoney = 0;
    int dailymoney = 0;
    int total = 0;


    public Text family;
    public Text daily;

    public Text Total;


    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //End of day of crop mission

        if (other.tag == "aftercrop")
        {
            dailymoney = Random.Range(5, 10);
            familymoney = Random.Range(5, 10);

            family.text = familymoney.ToString();
            daily.text = dailymoney.ToString();

            Total.text = familymoney.ToString() + dailymoney.ToString();

            

            moneytext.SetActive(true);
            Endofday.SetActive(true);
            GameObject.FindObjectOfType<TomatoCollector>().moneytoprint();
        }
    }
}
