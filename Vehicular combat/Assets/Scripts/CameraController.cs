using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject attachedVehicle;
    public GameObject cameraFolder;
    public Transform[] camLocations;
    public int locationIndicator = 2;

    //public Controller controlReft;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
