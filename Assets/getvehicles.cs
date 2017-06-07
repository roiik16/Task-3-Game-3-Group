using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getvehicles : MonoBehaviour {

    //this will random spawn the vehicles.
    public GameObject [] vehicleprefabs;

    public Transform spawnlocations;

    public int spawntimer = 2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Worktele")
        {
            StartCoroutine("Vehiclespawn");
        }
    }

    IEnumerator Vehiclespawn()
    {
        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0,2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(spawntimer);
        Instantiate(vehicleprefabs[Random.Range(0, 2)], spawnlocations.position, spawnlocations.rotation);

    }



}
