using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamge : MonoBehaviour
{
    //
    public int playerPushBackMagnitude = 40;
    public GameManagerSS gameManagerScript;

    public Rigidbody2D playerRB;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Diration player is shoved wwhen hitt
        Vector2 awayFromEnemyPushBack = new Vector2(transform.position.x - collision.transform.position.x, transform.position.y - transform.position.y).normalized;

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Missile"))
        {
            //Uppdat of UI when player hit
            gameManagerScript.UpdatePlayerHPUI();

            //Push back player
            playerRB.AddForce(awayFromEnemyPushBack * playerPushBackMagnitude ,ForceMode2D.Impulse);

            Debug.Log(gameObject.name + " hit by " + collision.gameObject.name);

            if (collision.gameObject.CompareTag("Missile")) // if hit by missile, destroy missile
            {
                Destroy(collision.gameObject);
            }

        }             
    }
}
