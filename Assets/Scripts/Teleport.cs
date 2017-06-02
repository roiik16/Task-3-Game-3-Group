using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

    public GameObject Exit;
    public GameObject GetOnnTruck;
    public GameObject obj;
    public GameObject obj1;
    //public GameObject Level1;


    public Transform findjob;
    public Transform Cropmissionteleport;
    public Transform GetOnTruck;
    public Transform Finish1;
    public Transform HouseWorkTele;

    bool spacetext1 = false;
    bool spacetext2 = false;
    bool spacetext3 = false;


    void Start()
    {
        Exit.SetActive(false);
        GetOnnTruck.SetActive(false);
        obj.SetActive(false);
        obj1.SetActive(false);
        GetOnnTruck.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(true);
            spacetext1 = true;
            Destroy(obj);
           

            //transform.position = destination.position;
        }

        if (other.tag == "GetOnTruck")
        {
            GetOnnTruck.SetActive(true);
            spacetext2 = true;
            //transform.position = GetOnTruck.position;
        }

        //TO WORK TEMPORARY
        if (other.tag == "HouseTele")
        {
            transform.position = HouseWorkTele.position;
            Debug.Log("hello");
        }



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext1)
        {
            transform.position = findjob.position;
            //Destroy(Exit);
            spacetext1 = false;
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext2)
        {
            transform.position = Cropmissionteleport.position;
            //Destroy(Exit);
            spacetext2 = false;
            GetOnnTruck.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.Y))
        {
            obj.SetActive(false);
            obj.SetActive(false);
            //Destroy(obj1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            obj.SetActive(true);
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(false);
            spacetext1 = false;
            obj1.SetActive(true);
        }

        if (other.tag == "GetOnTruck")
        {
            Exit.SetActive(false);
            spacetext2 = false;
        }



    }
}
