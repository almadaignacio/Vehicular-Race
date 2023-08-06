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

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if( gameManager.ScoreGoal == 1)
        {
            Cursor.lockState = CursorLockMode.None;

            GameObject.Find("Aang Car").GetComponent<PrometeoCarController>().enabled = enabled;
            GameObject.Find("Aang Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = false;
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
            Cursor.lockState = CursorLockMode.None;

            GameObject.Find("Aang Car").GetComponent<PrometeoCarController>().enabled = enabled;
            GameObject.Find("Aang Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = false;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = false;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = false;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = false;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = false;
            panel.SetActive(true);
        }

        if (other.gameObject.CompareTag("Car1"))
        {
            Cursor.lockState = CursorLockMode.None;

            GameObject.Find("Aang Car").GetComponent<PrometeoCarController>().enabled = enabled;
            GameObject.Find("Aang Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = false;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = false;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = false;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = false;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = false;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
