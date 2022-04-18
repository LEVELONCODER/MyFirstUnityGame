using System;
using UnityEngine;

public class CubeMovementScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed);
        }

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0, 0);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, speed, 0);
        }

        if(Input.GetKey(KeyCode.B)) 
        {
            rb.AddForce(0, -speed, 0);
        }
    }
}
