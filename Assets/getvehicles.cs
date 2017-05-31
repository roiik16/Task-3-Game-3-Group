using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getvehicles : MonoBehaviour {

    //this will random spawn the vehicles.
    public GameObject [] vehicleprefabs;

    public Transform spawnlocations;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Worktele")
        {
            StartCoroutine("Vehiclespawn");
        }
    }

    IEnumerator Vehiclespawn()
    {
        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0,3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

        yield return new WaitForSeconds(30);
        Instantiate(vehicleprefabs[Random.Range(0, 3)], spawnlocations.position, spawnlocations.rotation);

    }



}
