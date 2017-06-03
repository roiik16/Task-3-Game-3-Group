using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public GameObject spacetext;
    public GameObject conversation;
    bool spacetext1 = false;

    public GameObject spacetext22;
    public GameObject conversation2;
    bool spacetext2 = false;

    public GameObject spacetext33;
    public GameObject conversation3;
    bool spacetext3 = false;

    public GameObject spacetext44;
    public GameObject conversation4;
    bool spacetext4 = false;

    public GameObject spacetext55;
    public GameObject conversation5;
    bool spacetext5 = false;


    void Start()
    {
        spacetext.SetActive(false);
        conversation.SetActive(false);

        spacetext22.SetActive(false);
        conversation2.SetActive(false);

        spacetext33.SetActive(false);
        conversation3.SetActive(false);

        spacetext44.SetActive(false);
        conversation4.SetActive(false);

        spacetext55.SetActive(false);
        conversation5.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "twoo")
        {
            spacetext.SetActive(true);
            spacetext1 = true;
        }

        if (other.tag == "two")
        {
            spacetext22.SetActive(true);
            spacetext2 = true;
        }

        if (other.tag == "three")
        {
            spacetext33.SetActive(true);
            spacetext3 = true;
        }

        if (other.tag == "four")
        {
            spacetext44.SetActive(true);
            spacetext4 = true;
        }

        if (other.tag == "five")
        {
            spacetext55.SetActive(true);
            spacetext5 = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "twoo")
        {
            spacetext.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
        }

        if (other.tag == "two")
        {
            spacetext22.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
        }

        if (other.tag == "three")
        {
            spacetext33.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
        }

        if (other.tag == "four")
        {
            spacetext44.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
        }

        if (other.tag == "five")
        {
            spacetext55.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
        }



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext1)
        {
            conversation.SetActive(true);
            Destroy(spacetext);
        }

        if (Input.GetKeyDown(KeyCode.Y) && spacetext1)
        {
            conversation.SetActive(false);
            Destroy(conversation);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext2)
        {
            conversation2.SetActive(true);
            Destroy(spacetext22);
        }

        if (Input.GetKeyDown(KeyCode.Y) && spacetext2)
        {
            conversation2.SetActive(false);
            Destroy(conversation2);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext3)
        {
            conversation3.SetActive(true);
            Destroy(spacetext33);
        }

        if (Input.GetKeyDown(KeyCode.Y) && spacetext3)
        {
            conversation3.SetActive(false);
            Destroy(conversation3);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext4)
        {
            conversation4.SetActive(true);
            Destroy(spacetext44);
        }

        if (Input.GetKeyDown(KeyCode.Y) && spacetext4)
        {
            conversation4.SetActive(false);
            Destroy(conversation4);
        }

        if (Input.GetKeyDown(KeyCode.X) && spacetext5)
        {
            conversation5.SetActive(true);
            Destroy(spacetext55);
        }

        if (Input.GetKeyDown(KeyCode.Y) && spacetext5)
        {
            conversation5.SetActive(false);
            Destroy(conversation5);
        }




    }
}
