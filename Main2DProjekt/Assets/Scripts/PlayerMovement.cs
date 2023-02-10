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
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
