 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ScoreGoal;
    public Text text;
    public static GameManager inst;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        //text = GetComponent<TMP_Text>();
    }

    public void Win()
    {
            SceneManager.LoadScene(2);
    }

    public void incrementGoal()
    {
        ScoreGoal++;
        text.text =  "" + ScoreGoal;
    }
}
