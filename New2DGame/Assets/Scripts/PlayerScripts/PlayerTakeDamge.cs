using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamge : MonoBehaviour
{
    /// <summary>
    /// Handle Player damge and knoclback
    /// </summary>
    public int playerPushBackMagnitude = 40;

    public PlayerHealthManager PlayerHealthManager;

    public Rigidbody2D playerRB;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHitByEnemy(collision);
    }
    void PlayerHitByEnemy(Collision2D collider)
    {
        // Diration player is shoved when hitt
        Vector2 awayFromEnemyPushBack = new Vector2(transform.position.x - collider.transform.position.x, transform.position.y - transform.position.y).normalized;

        if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Missile"))
        {
            //Uppdate of UI when player hit
            PlayerHealthManager.UpdatePlayerHPUI();

            //Push back player
            playerRB.AddForce(awayFromEnemyPushBack * playerPushBackMagnitude, ForceMode2D.Impulse);

            Debug.Log(gameObject.name + " hit by " + collider.gameObject.name);

            if (collider.gameObject.CompareTag("Missile")) // if hit by missile, destroy missile
            {
                Destroy(collider.gameObject);
            }


        }
    }
}
