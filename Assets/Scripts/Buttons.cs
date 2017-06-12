using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityStandardAssets.Characters.FirstPerson;

public class Buttons : MonoBehaviour
{

    public AudioSource audioclip;

    public GameObject [] Introimages;
    public GameObject obj;

    public GameObject introcanvas;

    public void Button(string Play)
    {
      
    }

    public void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            StartCoroutine("Imagesanim");
        }
    }
    private void Start()
    {
        introcanvas.SetActive(true);

        audioclip = GetComponent<AudioSource>();
        audioclip.Play();

        GameObject.FindObjectOfType<FirstPersonController>().enabled = false;
    
        obj.SetActive(false);

    }

    IEnumerator Imagesanim()
    {
        yield return new WaitForSeconds(0);
        Introimages[10].SetActive(true);
        Introimages[0].SetActive(true);
        

        yield return new WaitForSeconds(8);
        Introimages[0].SetActive(false);
        Introimages[1].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[1].SetActive(false);
        Introimages[2].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[2].SetActive(false);
        Introimages[3].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[3].SetActive(false);
        Introimages[4].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[4].SetActive(false);
        Introimages[5].SetActive(true);



        yield return new WaitForSeconds(8);
        Introimages[5].SetActive(false);
        Introimages[6].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[6].SetActive(false);
        Introimages[7].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[7].SetActive(false);
        Introimages[8].SetActive(true);


        yield return new WaitForSeconds(8);
        Introimages[8].SetActive(false);
        Introimages[9].SetActive(true);
        
      
        yield return new WaitForSeconds(8);
        Introimages[9].SetActive(false);
        Introimages[10].SetActive(false);
        audioclip.Stop();
        obj.SetActive(true);
        GameObject.FindObjectOfType<FirstPersonController>().enabled = true;
        introcanvas.SetActive(false);

    }

}


