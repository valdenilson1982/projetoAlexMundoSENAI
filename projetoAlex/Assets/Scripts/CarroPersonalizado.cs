using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;

public enum Axel
{
    Front, Rear,
}
public enum DriverType
{
    Front, Rear, Full
}
[Serializable]
public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
    public Side side;

}

public enum Side
{
    Left, Right
}

public class CarroPersonalizado : MonoBehaviour
{

    public Wheel[] wheels;
    public DriverType driveType;


    private float torque;
    public float maxtorque;
    public float breakTorque = 200;
    public float maxAngulo = 30;
    public float turnSensitivity = 1f;//Sensibilidade do mouse

    private Rigidbody rbCar;
    private Vector2 input;

    private bool isBraek;

   public Transform centerOfMass;

    public float downForce;
    public float maxSpeed;
    private float speed;

    public float steerRadius;

    public TextMeshProUGUI speedText;

    public float r;

    void Start()
    {
        rbCar = GetComponent<Rigidbody>();
        //  rbCar.ResetCenterOfMass();
         rbCar.centerOfMass = centerOfMass.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

    }

    private void FixedUpdate()
    {
        SetTorque();
        AnimationWhees();
        Turn();
        SetBreak();
    }
    #region MEUS MÉTODOS
    private void GetInput()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBraek = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isBraek = false;
        }
    }


    private void SetTorque()
    {

        speed = rbCar.velocity.magnitude * 3.6f;

        speedText.text = speed.ToString("N0") + "km/h";

        if (speed >= maxSpeed) { torque = 0; }

        rbCar.AddForce(Vector3.down * downForce * speed);




        if (driveType == DriverType.Full)
        {
            torque = maxtorque / 4;
        }
        else
        {
            torque = breakTorque / 2;
        }

        foreach (Wheel w in wheels)
        {
            switch (driveType)
            {
                case DriverType.Full:

                    w.collider.motorTorque = input.y * torque;

                    break;

                case DriverType.Front:

                    if (w.axel == Axel.Front)
                    {
                        w.collider.motorTorque = input.y * torque;
                    }

                    break;

                case DriverType.Rear:

                    if (w.axel == Axel.Rear)
                    {
                        w.collider.motorTorque = input.y * torque;
                    }

                    break;



            }
        }

    }

    private void SetBreak()
    {
        foreach (Wheel w in wheels)
        {
            if (isBraek)
            {
                w.collider.motorTorque = 0;
                w.collider.brakeTorque = breakTorque;
            }
            else
            {
                w.collider.brakeTorque = 0;
            }
        }
    }

    private void Turn()
    {

        r = steerRadius;
        if(speed >= 100) { r = 10; }
        else if(speed >= 80) { r = 8; }
        else if(speed >= 60){ r = 6; }
        else if(speed>= 40) { r = 4; }
        else { r = 2.5f; }


        foreach (Wheel w in wheels)
        {
            if (w.axel == Axel.Front)
            {
                if (input.x > 0)
                {
                    switch (w.side)
                    {
                        case Side.Left:

                            w.collider.steerAngle = Mathf.Rad2Deg * MathF.Atan(2.55f / (r + (1.5f / 2))) * input.x;

                            break;
                        case Side.Right:

                            w.collider.steerAngle = Mathf.Rad2Deg * MathF.Atan(2.55f / (r - (1.5f / 2))) * input.x;

                            break;
                    }


                }
                else if (input.x < 0)
                {

                    switch (w.side)
                    {
                        case Side.Left:

                            w.collider.steerAngle = Mathf.Rad2Deg * MathF.Atan(2.55f / (r - (1.5f / 2))) * input.x;

                            break;
                        case Side.Right:

                            w.collider.steerAngle = Mathf.Rad2Deg * MathF.Atan(2.55f / (r + (1.5f / 2))) * input.x;

                            break;
                    }


                }
                else
                {
                    w.collider.steerAngle = 0;
                }

                // float steerAngle = input.x * turnSensitivity * maxAngulo;
                //  w.collider.steerAngle = steerAngle;

            }
        }
    }

    void AnimationWhees()
    {

        foreach (Wheel w in wheels)
        {
            Quaternion rot;
            Vector3 pos;
            w.collider.GetWorldPose(out pos, out rot);

            w.model.transform.position = pos;
            w.model.transform.rotation = rot;


        }
    }
    #endregion
}

