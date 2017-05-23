﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public GameObject spacetext;
    public GameObject conversation;

    bool spacetext1 = false;

    void Start()
    {
        spacetext.SetActive(false);
        conversation.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "twoo")
        {
            spacetext.SetActive(true);
            spacetext1 = true;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "twoo")
        {
            spacetext.SetActive(false);
            spacetext1 = false;
            conversation.SetActive(false);
            Destroy(other.gameObject);

        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && spacetext)
        {
            conversation.SetActive(true);
            spacetext.SetActive(false);
        }
    }
}
