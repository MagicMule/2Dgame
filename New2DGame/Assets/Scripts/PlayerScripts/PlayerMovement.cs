using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;

    public AudioClip jumpSound;
    private AudioSource playerAudio;

    public float runSpeed = 40f;
    public float horizontalMove = 0;
    bool jump = false;
    private Animator anim;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller2D = gameObject.AddComponent<CharacterController2D>();
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
        PlayerMove();
    }
    void PlayerMove()
    {
        //get left-right movment, from CharaterController2D
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; //Set Jump false, stop "dubble jumping"
    }
}