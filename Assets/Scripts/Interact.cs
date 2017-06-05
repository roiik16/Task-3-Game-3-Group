using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
   
    public GameObject conversation;
    bool spacetext1 = false;

    public GameObject conversation2;
    bool spacetext2 = false;

    public GameObject conversation3;
    bool spacetext3 = false;

    public GameObject conversation4;
    bool spacetext4 = false;

    public GameObject conversation5;
    bool spacetext5 = false;


    void Start()
    {
        conversation.SetActive(false);

        conversation2.SetActive(false);

        conversation3.SetActive(false);

        conversation4.SetActive(false);

        conversation5.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "twoo")
        {
            conversation.SetActive(true);
            spacetext1 = true;
            Debug.Log("Go Interact");
        }

        if (other.tag == "two")
        {
            conversation2.SetActive(true);
            spacetext2 = true;
            Debug.Log("Go Interact2");
        }

        if (other.tag == "three")
        {
            conversation3.SetActive(true);
            spacetext3 = true;
            Debug.Log("Go Interact3");
        }

        if (other.tag == "four")
        {
            conversation4.SetActive(true);
            spacetext4 = true;
            Debug.Log("Go Interact4");
        }

        if (other.tag == "five")
        {
            conversation5.SetActive(true);
            spacetext5 = true;
            Debug.Log("Go Interact5");
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "twoo")
        {
            Destroy(conversation);
            spacetext1 = false;
            
        }

        if (other.tag == "two")
        {
            Destroy(conversation2);
            spacetext2 = false;
        }

        if (other.tag == "three")
        {
            Destroy(conversation3);
            spacetext3 = false;
        }

        if (other.tag == "four")
        {
            Destroy(conversation4);
            spacetext4 = false;
        }

        if (other.tag == "five")
        {
            Destroy(conversation5);
            spacetext5 = false;
        }



    }
   

    }