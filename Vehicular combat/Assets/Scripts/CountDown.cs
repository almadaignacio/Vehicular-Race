using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public AudioSource threeSound;
    public AudioSource twoSound;
    public AudioSource oneSound;
    public AudioSource readySound;
    public AudioSource music;

    public GameObject lapTimer;

    public bool camAang;
    public bool camKatara;
    public bool camSokka;
    public bool camToph;
    public bool camZuko;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountDownRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        threeSound.Play();
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1f);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        twoSound.Play();
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1f);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        oneSound.Play();
        Countdown.SetActive(true);

        yield return new WaitForSeconds(1f);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "GO!";
        readySound.Play();
        Countdown.SetActive(true);

        if(camAang == true)
        {
            GameObject.Find("Aang Car").GetComponent<PrometeoCarController>().enabled = true;
            GameObject.Find("Aang Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
            music.Play();
        }

        if (camKatara == true)
        {
            GameObject.Find("Katara Car").GetComponent<PrometeoCarController>().enabled = true;
            GameObject.Find("Katara Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("Aang Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
            music.Play();
        }

        if (camSokka == true)
        {
            GameObject.Find("Sokka Car").GetComponent<PrometeoCarController>().enabled = true;
            GameObject.Find("Sokka Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Aang Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
            music.Play();
        }

        if (camToph == true)
        {
            GameObject.Find("Toph Car").GetComponent<PrometeoCarController>().enabled = true;
            GameObject.Find("Toph Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Aang Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Zuko Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
            music.Play();
        }

        if (camZuko == true)
        {
            GameObject.Find("Zuko Car").GetComponent<PrometeoCarController>().enabled = true;
            GameObject.Find("Zuko Car").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GameObject.Find("Katara Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Sokka Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Toph Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("Aang Car").GetComponent<Opponent>().enabled = true;
            GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
            GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
            GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
            GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
            GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
            music.Play();
        }

    }
}
