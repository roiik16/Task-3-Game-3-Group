using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;


namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Timer : MonoBehaviour
    {
        public GameObject Time;
        public GameObject bushes;
        public int timeLeft = 120;
        public Text countdownText;
        public bool timerIsActive = false;
        public Transform Finish1;
        bool spacetext3 = false;
        public GameObject EndLevel1;
        public GameObject obj3;
        public GameObject obj4;
        public GameObject ExhaustedText;

        public GameObject CropVan;
        public GameObject InjuryVan;
        public GameObject HouseVan;


        public GameObject croptele;
        void Start()
        {
            bushes.SetActive(true);
            Time.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            EndLevel1.SetActive(false);

            CropVan.SetActive(false);
            HouseVan.SetActive(false);
            InjuryVan.SetActive(false);
        }

        // Use this for initialization
        public void StartTimer()
        {
            if (!timerIsActive)
            {
                timerIsActive = true;
                StartCoroutine("LoseTime");
                Time.SetActive(true);
            }
        }

        public void StopTimer()
        {
            StopCoroutine("LostTime");
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Level1")
            {
                //Level1.SetActive(true);
                spacetext3 = false;
                //transform.position = GetOnTruck.position;

                countdownText.text = "";
                Time.SetActive(false);


                if (other.tag == "Level1" && timeLeft <= 0)
                {
                    transform.position = Finish1.position;
                    obj3.SetActive(false);
                    obj4.SetActive(true);
                    HouseVan.SetActive(true);
                }
            }
            if (other.tag == "GetInjured")
            {
                other.transform.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

        IEnumerator LoseTime()
        {
            while (true)
            {

                int randomnum = Random.Range(90, 150);

                yield return new WaitForSeconds(1);
                timeLeft--;

                countdownText.text = ("Work time left: " + timeLeft);

                if (timeLeft == randomnum)
                {
                    GameObject.FindObjectOfType<FirstPersonController>().Exhausted();
                    ExhaustedText.SetActive(true);
                }

                if (timeLeft <= 0)
                {
                    EndLevel1.SetActive(true);
                    StopTimer();
                    countdownText.text = "We are done for today, lets go";
                    timerIsActive = false;
                    spacetext3 = true;

                    ExhaustedText.SetActive(false);

                    //transform.position = GetOnTruck.position;

                    
                    croptele.SetActive(true);

                    StopCoroutine("LoseTime");
                }
            }
        }
    }
}
