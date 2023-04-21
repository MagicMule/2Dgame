using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public AudioClip jumpSound;

    //public Animator playerJumpAnimtion; // player jump animation

    private AudioSource playerAudio;

    public float runSpeed = 40f;
    public float horizontalMove = 0;
    bool jump = false;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Calculte player horizontal movment
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
     
        
        //player Jump, from CharaterController
        if (Input.GetButtonDown("Jump"))
        {
            //playerJumpAnimtion.SetBool("playerJump", true); // start jump animation
            playerAudio.PlayOneShot(jumpSound, 1.0f); // play jump sound clip
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        //get left-right movment, from CharaterController2D
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; //Set Jump false, stop "dubble jumping"
    }
}
