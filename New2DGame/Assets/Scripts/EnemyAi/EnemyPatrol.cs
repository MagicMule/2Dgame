using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 1f;

    public CharacterController2D characterController;

    Rigidbody2D enemyRB;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(moveSpeed, false, false);
    }

}
