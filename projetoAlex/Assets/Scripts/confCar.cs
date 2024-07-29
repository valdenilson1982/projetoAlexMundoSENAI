using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confCar : MonoBehaviour
{
    public WheelCollider FL;
    public WheelCollider FR;
    public WheelCollider RL;
    public WheelCollider RR;
    public WheelCollider RL1;
    public WheelCollider RR1;

    public float torque;
    public float breakTorque = 200;
    public float maxAngulo = 30;

    Vector2 input;


    public bool isBreak;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FL.motorTorque = 0;
            FR.motorTorque = 0;
            RL.motorTorque = 0;
            RR.motorTorque = 0;
            RL1.motorTorque = 0;
            RR1.motorTorque = 0;
            FL.brakeTorque = breakTorque;
            FR.brakeTorque = breakTorque;
            RL.brakeTorque = breakTorque;
            RR.brakeTorque = breakTorque;
            RL1.brakeTorque = breakTorque;
            RR1.brakeTorque = breakTorque;
            isBreak = true;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isBreak = false;
            FL.brakeTorque = 0;
            FR.brakeTorque = 0;
            RL.brakeTorque = 0;
            RR.brakeTorque = 0;
            RL1.brakeTorque = 0;
            RR1.brakeTorque = 0;

        }


    }

    private void FixedUpdate()
    {
        if (!isBreak)
        {
            FL.motorTorque = input.y * torque;
            FR.motorTorque = input.y * torque;
            RL.motorTorque = input.y * torque;
            RR.motorTorque = input.y * torque;
            RL1.motorTorque = input.y * torque;
            RR1.motorTorque = input.y * torque;
        }


        float steerAngre = input.x * maxAngulo;

        FL.steerAngle = steerAngre;

        FL.steerAngle = steerAngre;

    }

}
