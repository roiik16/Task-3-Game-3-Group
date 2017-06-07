using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public GameObject introcanvas;

    public void Start()
    {

    }

    public void Button(string Play)
    {
        introcanvas.SetActive(false);
    }

}


