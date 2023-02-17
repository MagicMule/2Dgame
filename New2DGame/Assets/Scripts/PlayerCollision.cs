using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject deathEffect;

    //collisions efekting the player
    void OnCollisionEnter (Collision col)
    {
        if (col.collider.tag == "Enemy")
        {
            Instantiate(deathEffect, transform.position,transform.rotation); //Instantiate Death animation, ad play att player objekt location
            GameManager.Instance.GameOver(); // exeute the GameOver funtion from GameManager

            FindObjectOfType<AudioManager>().Play("PlayerDeath"); // Play audio for player death

                Destroy(gameObject); // destry this compnent, (Player)
        }
    }
}
