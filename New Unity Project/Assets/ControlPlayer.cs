    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float fuelEfficiency = 1f;
    public float turnSpeed = 5000;
    public float horizontalInput;
    public float steerAngle;
    public float forwardInput;
    private bool gameOver = false;

    public WheelCollider frontDriverW = new WheelCollider(), frontPassW = new WheelCollider();
    public WheelCollider rearDriverW = new WheelCollider(), rearPassW = new WheelCollider();
    public Transform frontDriverT, frontPassT;
    public Transform rearDriverT, rearPassT;
    public float maxSteerAngle = 30;
    public float motorForce = 50;


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;    }

    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        steerAngle = maxSteerAngle * horizontalInput;
        frontDriverW.steerAngle = steerAngle;
        frontPassW.steerAngle = steerAngle;
    }

    private void Accelerate()
    {
        frontDriverW.motorTorque = forwardInput * motorForce;
        frontPassW.motorTorque = forwardInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(frontPassW, frontPassT);
        UpdateWheelPose(rearPassW, rearPassT);

    }

    private void UpdateWheelPose(WheelCollider collider, Transform transform)
    {
        Vector3 pos = transform.position;
        Quaternion quat = transform.rotation;

        collider.GetWorldPose(out pos, out quat);

        transform.position = pos;
        transform.rotation = quat;
    }

    void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
    }

}
