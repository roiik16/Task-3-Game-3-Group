using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public GameObject introcanvas;

    public GameObject [] Introimages;

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
        introcanvas.SetActive(true);
    }

    IEnumerator Imagesanim()
    {
        yield return new WaitForSeconds(0);
        Introimages[10].SetActive(true);
        Introimages[0].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[0].SetActive(false);
        Introimages[1].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[1].SetActive(false);
        Introimages[2].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[2].SetActive(false);
        Introimages[3].SetActive(true);

        yield return new WaitForSeconds(5);

        Introimages[3].SetActive(false);
        Introimages[4].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[4].SetActive(false);
        Introimages[5].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[5].SetActive(false);
        Introimages[6].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[6].SetActive(false);
        Introimages[7].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[7].SetActive(false);
        Introimages[8].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[8].SetActive(false);
        Introimages[9].SetActive(true);

        yield return new WaitForSeconds(5);
        Introimages[9].SetActive(false);

        Introimages[10].SetActive(false);
    }

}


