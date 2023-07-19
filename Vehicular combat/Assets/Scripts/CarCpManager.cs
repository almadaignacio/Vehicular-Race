using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCpManager : MonoBehaviour
{
    public int carNumber;
    public int cpCrossed = 0;
    public int carPosition;

    public RaceManager raceMaager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CP"))
        {
            cpCrossed += 1;
            raceMaager.carCollectedCP(carNumber, cpCrossed);
        }
    }
}
