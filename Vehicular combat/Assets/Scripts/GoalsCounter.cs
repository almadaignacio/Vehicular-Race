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
        //text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if( gameManager.ScoreGoal == 3)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;

            panel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.incrementGoal();
        }
    }

}