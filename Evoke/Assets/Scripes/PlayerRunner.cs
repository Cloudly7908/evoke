using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 200f;
    public float sideSpeed = 200f;

    void Start()
    {

    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if ( Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sideSpeed, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sideSpeed, 0, 0 * Time.deltaTime);
        }
    }
}
