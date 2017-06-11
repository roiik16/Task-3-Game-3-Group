using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{

    public GameObject onequote;
    public GameObject twoquote;
    public GameObject threequote;

    public GameObject conversation;
    bool spacetext1 = false;
    public GameObject End;
    public GameObject conversation2;
    bool spacetext2 = false;

    public GameObject conversation3;
    bool spacetext3 = false;

    public GameObject conversation4;
    bool spacetext4 = false;

    public GameObject conversation5;
    bool spacetext5 = false;

  

    public GameObject ConstructTruck;
    bool spacetext7 = false;

    public Transform Finish1;

    void Start()
    {
        conversation.SetActive(false);

        conversation2.SetActive(false);

        conversation3.SetActive(false);

        conversation4.SetActive(false);

        conversation5.SetActive(false);



        ConstructTruck.SetActive(false);
        End.SetActive(false);
        onequote.SetActive(false);
        twoquote.SetActive(false);
        threequote.SetActive(false);

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

       

        if (other.tag == "gtcInjured")
        {
                //transform.position = Finish1.position;
            Debug.Log("go home you're injured");
            End.SetActive(true);

            StartCoroutine("Ending");
        }


    }


    IEnumerator Ending()
    {
        yield return new WaitForSeconds(1);

        onequote.SetActive(true);
        yield return new WaitForSeconds(4);

        onequote.SetActive(false);
        twoquote.SetActive(true);
        yield return new WaitForSeconds(4);

        twoquote.SetActive(false);
        threequote.SetActive(true);
        yield return new WaitForSeconds(4);

        Application.Quit();

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