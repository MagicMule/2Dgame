using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController2D
    // INHERITANCE”: Both enemy and player use CharacterController2D
    
{
    
    [SerializeField] private Animator jumpAnimation; // Jump animation, to be active when player is not grounded 

    //CheckIfGrunded is a override to add jumpanimation to player
    public override void CheckIfGrunded()
    {
        base.CheckIfGrunded();
        PlayJumpAnimation(); // Play jump animtion based on grunded status
    }
    public void PlayJumpAnimation()
    {
        if (!m_Grounded)
        {
            jumpAnimation.SetBool("playerJump", true); // start player jump animation
        }
        else
        {
            jumpAnimation.SetBool("playerJump", false); // Stop player jump animation
        }
    }
    

}
