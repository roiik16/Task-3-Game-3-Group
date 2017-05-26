using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public int timeLeft = 240;
    public Text countdownText;

    // Use this for initialization
    void Start () {
        StartCoroutine("LoseTime");
    }
	
	// Update is called once per frame
	void Update () {
        //CountDown
        countdownText.text = ("Time Left: " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            SceneManager.LoadScene("GameOver");

        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
