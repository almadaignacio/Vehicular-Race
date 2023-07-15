using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] protected WheelCollider frontRight;
    [SerializeField] protected WheelCollider frontLeft;
    [SerializeField] protected WheelCollider backRight;
    [SerializeField] protected WheelCollider backLeft;

    [SerializeField] protected Transform frontRightWheel;
    [SerializeField] protected Transform frontLeftWheel;
    [SerializeField] protected Transform backRightWheel;
    [SerializeField] protected Transform backLeftWheel;

    [SerializeField] protected float acceleration;
    [SerializeField] protected float breakingForce;
    [SerializeField] protected float maxTurnAngle;

    protected float currentAcceleration = 0f;
    protected float currentBreakForce = 0f;
    protected float currentTurnAngle = 0f;

    // Shoot Setup

    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform bulletSpawn;
    [SerializeField] protected Transform carBody;

    [SerializeField] protected float bulletForce;
    [SerializeField] protected float timeToFire;
    protected float timer;
    protected bool canFire;

    //Car stats

    [SerializeField] protected float hp;

    private void FixedUpdate()
    {
        WheelLogic();
        currentAcceleration = acceleration * Input.GetAxis("Vertical") * Time.deltaTime;
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal") * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakingForce;
        }
        else
        {
            currentBreakForce = 0f;
        }
    }
        protected void WheelLogic()
    {
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        UpdateWheel(frontLeft, frontLeftWheel);
        UpdateWheel(frontRight, frontRightWheel);
        UpdateWheel(backLeft, backLeftWheel);
        UpdateWheel(backRight, backRightWheel);
    }

    protected void UpdateWheel(WheelCollider col, Transform trans)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;
    }
}
