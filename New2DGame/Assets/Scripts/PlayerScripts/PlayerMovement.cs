using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;

    public float runSpeed = 40f;
    public float horizontalMove = 0;
    bool jump = false;

    void Update()
    {
        //Calculte player horizontal movment
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        
        //player Jump, from CharaterController
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump button presed");
            jump = true;
        }

        // Check for current world and stage
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(GameManager.Instance.world + " " + GameManager.Instance.stage);
        }
    }
    private void FixedUpdate()
    {
        //get left-right movment, from CharaterController2D
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; //Set Jump false, stop "dubble jumping"
    }
}
