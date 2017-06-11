using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class EndofDayController : MonoBehaviour
{

    public int timeLeft = 10;

    public GameObject Endofday;
    //public GameObject moneytext;
    int CropWork = 0;
    int familymoney = 0;
    int dailymoney = 0;

    int total = 0;


    public Text family;
    public Text daily;
    public Text Crop;

    public Text Total;


    // Use this for initialization
    void Start()
    {
        Endofday.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Endofday.SetActive(false);
            family.text = "";
            daily.text = "";
            Crop.text = "";
            total.text = "";
            print("del");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //End of day of crop mission

        if (other.tag == "aftercrop")
        {
            dailymoney = Random.Range(5, 10);
            familymoney = Random.Range(5, 10);
            CropWork = Random.Range(10, 20);

            family.text = familymoney.ToString();
            daily.text = dailymoney.ToString();
            Crop.text = CropWork.ToString();

            total = familymoney + dailymoney + CropWork;
            Total.text = "" + total.ToString();

            //moneytext.SetActive(true);
            Endofday.SetActive(true);
            //GameObject.FindObjectOfType<TomatoCollector>().moneytoprint();

        }

    }
}