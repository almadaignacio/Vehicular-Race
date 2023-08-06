using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class RaceManager : MonoBehaviour
{
    public GameObject Cp;
    public GameObject CheckPointHolder;

    public GameObject[] Cars;
    public Transform[] CheckPointPositions;
    public GameObject[] CheckPointforEachCar;

    private int totalCars;
    private int totalCheckPoints;

    public Text postitionTxt;

    // Start is called before the first frame update
    void Start()
    {
        totalCars = Cars.Length;
        totalCheckPoints = CheckPointHolder.transform.childCount;

        setCheckpoints();
        setCarPosition();
    }

    void setCheckpoints()
    {
        CheckPointPositions = new Transform[totalCheckPoints];

        for (int i = 0; i < totalCheckPoints; i++)
        {
            CheckPointPositions[i] = CheckPointHolder.transform.GetChild(i).transform;
        }

        CheckPointforEachCar = new GameObject[totalCars];

        for (int i = 0; i < totalCars; i++)
        {
            CheckPointforEachCar[i] = Instantiate(Cp, CheckPointPositions[0].position, CheckPointPositions[0].rotation);
            CheckPointforEachCar[i].name = "CP " + i;
            CheckPointforEachCar[i].layer = 6 + i;
        }
    }
    void setCarPosition()
    {
        for(int i= 0; i<totalCars; i++)
        {
            Cars[i].GetComponent<CarCpManager>().carPosition = i + 1;
            Cars[i].GetComponent<CarCpManager>().carNumber = i;

        }
        postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "st";
    }


    public void carCollectedCP(int carNumber, int cpNumber)
    {
        CheckPointforEachCar[carNumber].transform.position = CheckPointPositions[cpNumber].transform.position;
        CheckPointforEachCar[carNumber].transform.rotation = CheckPointPositions[cpNumber].transform.rotation;

        comparePositions(carNumber);
    }

    void comparePositions(int carNumber)
    {
        if (Cars[carNumber].GetComponent<CarCpManager>().carPosition > 1)
        {
            GameObject currentCar = Cars[carNumber];
            int currentCarPos = currentCar.GetComponent<CarCpManager>().carPosition;
            int currentCarCp = currentCar.GetComponent<CarCpManager>().cpCrossed;


            GameObject carInFront = null;
            int carInFrontPos = 0;
            int carInFrontCp = 0;

            for (int i = 0; i < totalCars; i++)
            {
                if (Cars[i].GetComponent<CarCpManager>().carPosition == currentCarPos- 1)
                {
                    carInFront = Cars[i];
                    carInFrontCp = carInFront.GetComponent<CarCpManager>().cpCrossed;
                    carInFrontPos = carInFront.GetComponent<CarCpManager>().carPosition;
                    break;
                }
            }
            
            if(currentCarCp > carInFrontCp)
            {
                currentCar.GetComponent<CarCpManager>().carPosition = currentCarPos - 1;
                carInFront.GetComponent<CarCpManager>().carPosition = carInFrontPos + 1;

                Debug.Log("Car " + carNumber + " Has over taken " + carInFront.GetComponent<CarCpManager>().carNumber);
            }


            if (Cars[0].GetComponent<CarCpManager>().carPosition == 1)
            {
                postitionTxt.GetComponent<Text>().color = Color.yellow;
                postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "st";
            }

            if (Cars[0].GetComponent<CarCpManager>().carPosition == 2)
            {
                postitionTxt.GetComponent<Text>().color = Color.blue;
                postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "nd";
            }

            if (Cars[0].GetComponent<CarCpManager>().carPosition == 3)
            {
                postitionTxt.GetComponent<Text>().color = Color.green;
                postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "rd";
            }

            if (Cars[0].GetComponent<CarCpManager>().carPosition == 4)
            {
                postitionTxt.GetComponent<Text>().color = Color.gray;
                postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "th";
            }

            if (Cars[0].GetComponent<CarCpManager>().carPosition == 5)
            {
                postitionTxt.GetComponent<Text>().color = Color.gray;
                postitionTxt.text = Cars[0].GetComponent<CarCpManager>().carPosition + "th";
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
