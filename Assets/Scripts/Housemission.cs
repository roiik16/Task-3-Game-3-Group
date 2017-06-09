using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Housemission : MonoBehaviour {

    public GameObject GetoutText;
    public GameObject HouseVan;
    public GameObject InjuryVan;
    public Transform backtobunker;


    void Start()
    {
        
        //CropVan.SetActive(false);
        HouseVan.SetActive(false);
        InjuryVan.SetActive(false);
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
        }
    }
}
