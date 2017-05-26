using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

    public GameObject Exit;
    public GameObject GetOnnTruck;

    public Transform destination;
    public Transform GetOnTruck;

    bool spacetext1 = false;
    bool spacetext2 = false;


    void Start()
    {
        Exit.SetActive(false);
        GetOnnTruck.SetActive(false);
        //GetOnnTruck.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BunkerTeleporter")
        {
            Exit.SetActive(true);
            spacetext1 = true;
            //transform.position = destination.position;
        }

        if (other.tag == "GetOnTruck")
        {
            GetOnnTruck.SetActive(true);
            spacetext2 = true;
            //transform.position = GetOnTruck.position;
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext1)
        {
            transform.position = destination.position;
            //Destroy(Exit);
            spacetext1 = false;
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext2)
        {
            transform.position = GetOnTruck.position;
            //Destroy(Exit);
            spacetext2 = false;
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
