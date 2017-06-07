﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

    public GameObject Exit;
    public GameObject GetOnnTruck;

    public GameObject CropVan;
    public GameObject InjuryVan;
    public GameObject HouseVan;

    public GameObject Level1;

    public GameObject obj;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj4;
    
    public Transform findjob;
    public Transform Cropmissionteleport;
    public Transform GetOnTruck;
    public Transform Finish1;
    public Transform HouseWorkTele;
    public Transform ConstructWork;

    bool spacetext1 = false;
    bool spacetext2 = false;
    bool spacetext3 = false;


    void Start()
    {
        Exit.SetActive(false);
        GetOnnTruck.SetActive(false);
        obj.SetActive(true);
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj4.SetActive(false);
        GetOnnTruck.SetActive(false);
        CropVan.SetActive(false);
        HouseVan.SetActive(false);
        InjuryVan.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(true);
            spacetext1 = true;
            CropVan.SetActive(true);
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

        if (other.tag == "gtcInjured")
        {
            Debug.Log("go home");
            if (Input.GetKeyDown(KeyCode.X)) { 
            transform.position = Finish1.position;
            Debug.Log("go home you're injured");
            }
        }



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext1)
        {
            transform.position = findjob.position;
            Destroy(obj);
            
            spacetext1 = false;
            obj1.SetActive(true);
        }

        //LUDWIG HERE - Mhux vera :O
       

        if (Input.GetKeyDown(KeyCode.X) && spacetext2)
        {
            transform.position = Cropmissionteleport.position;
            spacetext2 = false;
            GetOnnTruck.SetActive(false);
            Destroy(CropVan);
            Destroy(obj1);
            obj2.SetActive(true);

        }
        


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(false);
            spacetext1 = false;
            
        }

        if (other.tag == "GetOnTruck")
        {
            Exit.SetActive(false);
            spacetext2 = false;
        }

    }
}
