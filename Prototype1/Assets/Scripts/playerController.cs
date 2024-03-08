using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed=40.0f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward* Time.deltaTime*speed*verticalInput);
        //Rotate the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
