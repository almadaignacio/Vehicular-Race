using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    public WheelCollider[] wheels;
    public float motorPower = 100;
    public float steerPower = 100;

    public GameObject centerOfMass;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass.transform.localPosition;
    }

    private void FixedUpdate()
    {
        foreach (var wheel in wheels)
        {
            wheel.motorTorque = Input.GetAxis("Vertical") * ((motorPower * 5)) * Time.deltaTime;
        }

        for (int i = 0; i < wheels.Length; i++)
        {
            if(i < 2)
            {
                wheels[i].steerAngle = Input.GetAxis("Horizontal") * steerPower;
            }
        }
    }
}
