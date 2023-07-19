using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timerIsRunning = true;
    public TMP_Text timeText;
    private RaceManager raceManager;

    public GameObject TimeOut;

    public GameObject p1;
    public GameObject P2;

    // Start is called before the first frame update
    void Start()
    {
        raceManager = GetComponent<RaceManager>();
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
                
                if (timeRemaining >= 360)
                {
                    GameObject.Find("|||||PLAYER||||||").GetComponent<SimpleController>().enabled = enabled;
                    GameObject.Find("|||||PLAYER||||||").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
                    GameObject.Find("Car").GetComponent<Opponent>().enabled = false;
                    GameObject.Find("TMP counter").GetComponent<Timer>().enabled = false;
                    GameObject.Find("reloj").GetComponent<Animator>().enabled = false;
                    GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = false;
                    GameObject.Find("Image izq").GetComponent<Animator>().enabled = false;
                    GameObject.Find("Image der").GetComponent<Animator>().enabled = false;

                    StartCoroutine(TimeOutRutine());
                }

            }
        }

        

    }
    IEnumerator TimeOutRutine()
    {
        yield return new WaitForSeconds(1f);
        TimeOut.SetActive(true);
        yield return new WaitForSeconds(2f);
        TimeOut.SetActive(false);
        yield return new WaitForSeconds(1f);
        p1.SetActive(true);
        Cursor.lockState = CursorLockMode.None;



    }

    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds); 
    }
}
