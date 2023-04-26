using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisslePowerUp : MonoBehaviour
{
    /* 
     * this script sets a bool, missileAttack Ready, to true.
     * Used for the player to get access to a ranged missile attack
    */

    public PlayerAttack playerAttack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerAttack.missileAttackReady = true;
            Destroy(gameObject);
        }
    }
}
