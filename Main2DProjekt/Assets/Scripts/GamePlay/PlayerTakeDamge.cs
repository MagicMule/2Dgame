using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamge : MonoBehaviour
{
    public int playerHp = 10;
    private Rigidbody2D playerRb;
    public int playerPushBackMagnitude = 40;

    void Start()
    {
        playerRb= GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 playerPushBack = new Vector2((gameObject.transform.position.x - collision.transform.position.x) * playerPushBackMagnitude, gameObject.transform.position.y - collision.transform.position.y);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(collision.gameObject.name + " Hit " + gameObject.name);
            playerRb.AddForce(playerPushBack,ForceMode2D.Impulse);
            playerHp -= 1;
            Debug.Log(playerHp);
        }
        if (playerHp< 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
