/*
* (Jerod Lockhart)
* (Prototype 1)
* (makes the bus move)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public Vector3 direction;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb= this.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
