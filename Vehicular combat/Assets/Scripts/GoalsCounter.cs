using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalsCounter : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject panel;
    public GameObject panel2;


    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if( gameManager.ScoreGoal == 1)
        {
            Cursor.lockState = CursorLockMode.None;

            GameObject.Find("|||||PLAYER||||||").GetComponent<SimpleController>().enabled = enabled;
            GameObject.Find("|||||PLAYER||||||").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            GameObject.Find("Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = false;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = false;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = false;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = false;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = false;

            panel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.incrementGoal();
        }

        if (other.gameObject.CompareTag("Car1"))
        {
            GameObject.Find("|||||PLAYER||||||").GetComponent<SimpleController>().enabled = enabled;
            GameObject.Find("|||||PLAYER||||||").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            GameObject.Find("Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = false;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = false;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = false;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = false;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            panel2.SetActive(true);
        }
    }

}
