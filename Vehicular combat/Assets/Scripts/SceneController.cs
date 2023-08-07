using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool Level;
    public int indexlevel;
    public GameObject UiForPlaying;

    public GameObject poseAang;
    public GameObject ImgAang;
    public GameObject poseKatara;
    public GameObject ImgKatara;
    public GameObject poseSokka;
    public GameObject ImgSokka;
    public GameObject poseToph;
    public GameObject ImgToph;
    public GameObject poseZuko;
    public GameObject ImgZuko;

    public Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Level)
        {
            ChangeLevel(indexlevel);
        }
    }

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        UiForPlaying.SetActive(true);
    }

    public void NoGame()
    {
        UiForPlaying.SetActive(false);
    }
    
    public void Katara()
    {
        poseKatara.SetActive(true);
        ImgKatara.SetActive(true);

        poseAang.SetActive(false);
        ImgAang.SetActive(false);

        poseSokka.SetActive(false);
        ImgSokka.SetActive(false);

        poseToph.SetActive(false);
        ImgToph.SetActive(false);

        poseZuko.SetActive(false);
        ImgZuko.SetActive(false);
    }

    public void Aang()
    {
        poseKatara.SetActive(false);
        ImgKatara.SetActive(false);

        poseAang.SetActive(true);
        ImgAang.SetActive(true);

        poseSokka.SetActive(false);
        ImgSokka.SetActive(false);

        poseToph.SetActive(false);
        ImgToph.SetActive(false);

        poseZuko.SetActive(false);
        ImgZuko.SetActive(false);
    }

    public void Sokka()
    {
        poseKatara.SetActive(false);
        ImgKatara.SetActive(false);

        poseAang.SetActive(false);
        ImgAang.SetActive(false);

        poseSokka.SetActive(true);
        ImgSokka.SetActive(true);

        poseToph.SetActive(false);
        ImgToph.SetActive(false);

        poseZuko.SetActive(false);
        ImgZuko.SetActive(false);
    }

    public void Toph()
    {
        poseKatara.SetActive(false);
        ImgKatara.SetActive(false);

        poseAang.SetActive(false);
        ImgAang.SetActive(false);

        poseSokka.SetActive(false);
        ImgSokka.SetActive(false);

        poseToph.SetActive(true);
        ImgToph.SetActive(true);

        poseZuko.SetActive(false);
        ImgZuko.SetActive(false);
    }

    public void Zuko()
    {
        poseKatara.SetActive(false);
        ImgKatara.SetActive(false);

        poseAang.SetActive(false);
        ImgAang.SetActive(false);

        poseSokka.SetActive(false);
        ImgSokka.SetActive(false);

        poseToph.SetActive(false);
        ImgToph.SetActive(false);

        poseZuko.SetActive(true);
        ImgZuko.SetActive(true);
    }
    
}
