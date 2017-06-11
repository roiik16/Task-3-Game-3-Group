using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityStandardAssets.Characters.FirstPerson;

public class Buttons : MonoBehaviour
{

    public AudioSource audioclip;

    public GameObject introcanvas;
    public GameObject introimage1;
    public GameObject introimage2;
    public GameObject introimage3;
    public GameObject introimage4;
    public GameObject introimage5;
    public GameObject introimage6;
    public GameObject introimage7;
    public GameObject introimage8;
    public GameObject introimage9;
    public GameObject introimage10;

    public GameObject [] Introimages;
    public GameObject obj;

    public void Button(string Play)
    {
      
    }

    public void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            introcanvas.SetActive(false);
            StartCoroutine("Imagesanim");
        }
    }
    private void Start()
    {

        audioclip = GetComponent<AudioSource>();

        audioclip.Play();

        GameObject.FindObjectOfType<FirstPersonController>().enabled = false;
        introcanvas.SetActive(true);
        obj.SetActive(false);
        introimage1.SetActive(false);
        introimage2.SetActive(false);
        introimage3.SetActive(false);
        introimage4.SetActive(false);
        introimage5.SetActive(false);
        introimage6.SetActive(false);
        introimage7.SetActive(false);
        introimage8.SetActive(false);
        introimage9.SetActive(false);
        introimage10.SetActive(false);
    }

    IEnumerator Imagesanim()
    {
        yield return new WaitForSeconds(0);
        Introimages[10].SetActive(true);
        Introimages[0].SetActive(true);
        introimage1.SetActive(true);
        

        yield return new WaitForSeconds(5);
        Introimages[0].SetActive(false);
        Introimages[1].SetActive(true);
        introimage1.SetActive(false);
        introimage2.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[1].SetActive(false);
        Introimages[2].SetActive(true);
        introimage2.SetActive(false);
        introimage3.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[2].SetActive(false);
        Introimages[3].SetActive(true);
        introimage3.SetActive(false);
        introimage4.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[3].SetActive(false);
        Introimages[4].SetActive(true);
        introimage4.SetActive(false);
        introimage5.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[4].SetActive(false);
        Introimages[5].SetActive(true);
        introimage5.SetActive(false);
        introimage6.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[5].SetActive(false);
        Introimages[6].SetActive(true);
        introimage6.SetActive(false);
        introimage7.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[6].SetActive(false);
        Introimages[7].SetActive(true);
        introimage7.SetActive(false);
        introimage8.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[7].SetActive(false);
        Introimages[8].SetActive(true);
        introimage8.SetActive(false);
        introimage9.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[8].SetActive(false);
        Introimages[9].SetActive(true);
        introimage9.SetActive(false);
        introimage10.SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[9].SetActive(false);

        introimage10.SetActive(false);

        Introimages[10].SetActive(false);
        obj.SetActive(true);
        GameObject.FindObjectOfType<FirstPersonController>().enabled = true;

        audioclip.Stop();
    }

}


