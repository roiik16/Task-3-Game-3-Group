using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public int timeLeft = 120;
    public Text countdownText;
    public bool timerIsActive = false;
    public Transform Finish1;
    bool spacetext3 = false;


    // Use this for initialization
    public void StartTimer() {
        if (!timerIsActive)
        {
            timerIsActive = true;
            StartCoroutine("LoseTime");
            Debug.Log("okokok");
        }
    }

    public void StopTimer()
    {
        StopCoroutine("LostTime");
    }

    private void OnTriggerEnter()
    {

        if (other.tag == "Level1")
        {
            //Level1.SetActive(true);
            spacetext3 = true;
            //transform.position = GetOnTruck.position;
            transform.position = Finish1.position;
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;

            countdownText.text = ("Time Left: " + timeLeft);

            if (timeLeft <= 0)
            {
                StopTimer();
                countdownText.text = "Go to the truck!";
                timerIsActive = false;
                spacetext3 = true;
                //transform.position = GetOnTruck.position;
                transform.position = Finish1.position;
            }
        }
    }
}
