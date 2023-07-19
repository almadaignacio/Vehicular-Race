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

        GameObject.Find("|||||PLAYER||||||").GetComponent<SimpleController>().enabled = true;
        GameObject.Find("|||||PLAYER||||||").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GameObject.Find("Car").GetComponent<Opponent>().enabled = true;
        GameObject.Find("TMP counter").GetComponent<Timer>().enabled = true;
        GameObject.Find("reloj").GetComponent<Animator>().enabled = true;
        GameObject.Find("vacio aguja").GetComponent<VisualClockl>().enabled = true;
        GameObject.Find("Image izq").GetComponent<Animator>().enabled = true;
        GameObject.Find("Image der").GetComponent<Animator>().enabled = true;
        music.Play();
    }
}
