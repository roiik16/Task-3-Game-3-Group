using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFuits : MonoBehaviour {

    public GameObject Fruit;
    int spawnNum = 8;


	// Use this for initialization
	void Spawn ()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            Vector3 fruitPos = new Vector3 (this.transform.position.x + Random.Range(-0.4f, 0.4f),
                                            this.transform.position.y + Random.Range(-0.1f, 1.5f),
                                            this.transform.position.z + Random.Range(-0.4f, 0.4f));


            Instantiate(Fruit, fruitPos, Quaternion.identity);
        }
	}


    // Use this for initialization
    private void Start()
    {
        Spawn();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
