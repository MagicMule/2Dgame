using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Simple move forward script

    private Rigidbody2D rB;

    public int forwardSpeed = 1;


    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // move objekt on the x axes 
    void Update()
    {
        transform.Translate(transform.up * forwardSpeed * Time.deltaTime, Space.World);
    }
}
