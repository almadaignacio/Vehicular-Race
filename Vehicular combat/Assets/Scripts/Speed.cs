using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public GameObject nitro;
    public GameObject speedImage;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Speedd());
        }
    }

    IEnumerator Speedd()
    {
        speedImage.SetActive(true);
        nitro.SetActive(true);
        yield return new WaitForSeconds(8f);
        nitro.SetActive(false);
        speedImage.SetActive(false);
    }
}
