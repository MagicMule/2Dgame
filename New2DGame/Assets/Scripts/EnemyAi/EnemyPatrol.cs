using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyPatrol : MonoBehaviour
{

    public CharacterController2D controller2D;

    public float moveSpeed = 1f;

    private void FixedUpdate()
    {
        controller2D.Move(moveSpeed * Time.fixedDeltaTime, false, false); // move with charaktercontroller2D script
    }
    public void Turn()
    {
        moveSpeed *= (-1); // flip the movement
    }
}
