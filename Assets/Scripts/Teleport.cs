using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


public class Teleport : MonoBehaviour {

    public GameObject Exit;
    public GameObject GetOnnTruck;

    public GameObject CropVan;
    public GameObject InjuryVan;
    public GameObject HouseVan;

    public GameObject End;

    public GameObject Level1;

    public GameObject obj;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;

    public Transform findjob;
    public Transform Cropmissionteleport;
    public Transform GetOnTruck;
    public Transform Finish1;
    public Transform HouseWorkTele;
    public Transform ConstructWork;
    public Transform HouseWork;
    public Transform InjuryWork;

    bool spacetext1 = false;
    bool spacetext2 = false;
    bool spacetext3 = false;
    bool spacetext4 = false;
    bool spacetext5 = false;


    void Start()
    {
        Exit.SetActive(false);
        GetOnnTruck.SetActive(false);
        obj.SetActive(true);
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj4.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(false);
        obj7.SetActive(false);
        GetOnnTruck.SetActive(false);
        CropVan.SetActive(false);
        HouseVan.SetActive(false);
        InjuryVan.SetActive(false);
        End.SetActive(false);
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
        
        //TO change after..
        if (other.tag == "HouseTele")
        {
            transform.position = HouseWorkTele.position;
            Debug.Log("hello");
            
        }

        if (other.tag == "gtcInjured")
        {
            Debug.Log("dahal u ma komplpix");
            if (Input.GetKeyDown(KeyCode.X)) { 
            //transform.position = Finish1.position;
            Debug.Log("go home you're injured");
            End.SetActive(true);
            }
        }

        if (other.tag == "GoHouse")
        {
            Debug.Log("go home");
            GetOnnTruck.SetActive(true);
            spacetext4 = true;
            
        }

        if (other.tag == "GoInjured")
        {
            Debug.Log("dahal hazin");
            GetOnnTruck.SetActive(true);
            spacetext5 = true;
            obj1.SetActive(false);
            obj7.SetActive(true);
        }



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext1)
        {
            transform.position = findjob.position;
            Destroy(obj);
            obj4.SetActive(false);
            obj6.SetActive(false);
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
            obj1.SetActive(false);
            obj2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext4)
        {
            transform.position = HouseWork.position;
            spacetext4 = false;
            GetOnnTruck.SetActive(false);
            //Destroy(CropVan);
            //Destroy(obj1);
            //obj2.SetActive(true);
            obj1.SetActive(false);
            obj5.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext5)
        {
            transform.position = InjuryWork.position;
            spacetext4 = false;
            GetOnnTruck.SetActive(false);
            //Destroy(CropVan);
            //Destroy(obj1);
            //obj2.SetActive(true);

        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(false);
            spacetext1 = false;
            GameObject.FindObjectOfType<FirstPersonController>().NormalSpeed();
        }

        if (other.tag == "GetOnTruck")
        {
            Exit.SetActive(false);
            spacetext2 = false;
        }

    }
}
