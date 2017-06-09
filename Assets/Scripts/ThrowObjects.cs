using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class ThrowObjects : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    public int dmg;
    private bool touched = false;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerCam = Camera.main.transform;
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 1.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("Use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;

            GameObject.FindObjectOfType<FirstPersonController>().Exhausted();
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;

                GameObject.FindObjectOfType<FirstPersonController>().NormalSpeed();
            }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                GameObject.FindObjectOfType<FirstPersonController>().NormalSpeed();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (beingCarried)
        {
            touched = true;
          
        }
    }
}