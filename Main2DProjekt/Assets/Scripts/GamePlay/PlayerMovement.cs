using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public float runSpeed = 40f;
    float horizontalMove = 0;
    bool jump = false;
    void Start()
    {
        
    }

    void Update()
    {
        //Calculte player horizontal movment
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        
        //player Jump, from CharaterController
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        //get left-right movment, from CharaterController
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; //Set Jump false, stop "dubble jumping"
    }
}
