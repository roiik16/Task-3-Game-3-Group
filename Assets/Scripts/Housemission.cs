using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Housemission : MonoBehaviour {

    public GameObject GetoutText;
    public GameObject HouseVan;
    public GameObject InjuryVan;

    public GameObject housetele;
     
    public Transform backtobunker;

    public GameObject obj5;
    public GameObject obj6;


    void Start()
    {
        
        //CropVan.SetActive(false);
        HouseVan.SetActive(false);
        InjuryVan.SetActive(false);
        obj5.SetActive(false);
        obj6.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Getout")
        {
            GetoutText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Getout")
        {

            Destroy(HouseVan);
            GetoutText.SetActive(false);
            transform.position = backtobunker.position;
            InjuryVan.SetActive(true);
            obj5.SetActive(false);
            obj6.SetActive(true);

            housetele.SetActive(true);

        }
    }
}
