using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Housemission : MonoBehaviour {

    public GameObject GetoutText;
    public Transform backtobunker;

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
            GetoutText.SetActive(false);
            transform.position = backtobunker.position;
        }
    }
}
