using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPosition : MonoBehaviour
{
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;

    public GameObject Stat;

    public int AICarNumber;
    public bool Player;
    private int Pos;

    public CarCpManager CarCpManager;

    // Start is called before the first frame update
    void Start()
    {
        if(AICarNumber == 1)
        {
            Pos = CarCpManager.carPosition; 
        }
        if (AICarNumber == 2)
        {
            Pos = CarCpManager.carPosition;
        }
        if (AICarNumber == 3)
        {
            Pos = CarCpManager.carPosition;
        }
        if (AICarNumber == 4)
        {
            Pos = CarCpManager.carPosition; 
        }
        if (Player == true)
        {
            Pos = CarCpManager.carPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Pos == 0)
        {
            Stat.SetActive(false);
        }

        if (Pos == 1)
        {
            Stat.transform.position = Slot1.transform.position;
        }

        if (Pos == 2)
        {
            Stat.transform.position = Slot2.transform.position;
        }

        if (Pos == 3)
        {
            Stat.transform.position = Slot3.transform.position;
        }

        if (Pos == 4)
        {
            Stat.transform.position = Slot4.transform.position;
        }

        if (Pos == 5)
        {
            Stat.transform.position = Slot5.transform.position;
        }
    }
}
