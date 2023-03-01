using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    public GameObject Player;
    public GameManagerSS gameManagerScript;

    public float pushDistanse = 10f;
    public int enemyHealth = 10;
    public float enemySpeed = 5;

    private Vector3 moveToPlayer;

    public bool isShoter = false;
    public bool IsFlying = false;
    public bool enemyStop = false;

    private float playerEnemyXDistance;
    public float playerEnemyXDistanceMax = 3;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        EnemyMissileAttack();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        EnemyMoveToPlayer();
    }


    //When enemy hit by sword
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Players sword colliton with enemy
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log(collision.gameObject.name + " hit " + gameObject.name);
            enemyHealth -= 1;
            // Push enemy up and away from attack
            enemyRb.AddForce(new Vector2((gameObject.transform.position.x - Player.transform.position.x), 1).normalized * pushDistanse, ForceMode2D.Impulse);

        }
        if (enemyHealth <= 0)
        {
            Debug.Log("Enemy destroyed: " + gameObject.name);
            gameManagerScript.UpdateScoreUI(); //Update Score
            Destroy(gameObject);
        }

    }

    //Movinge to player on X
    void EnemyMoveToPlayer()
    {
        //Disdance form player and enemy on the X axes
        playerEnemyXDistance = Mathf.Abs(Player.transform.position.x - gameObject.transform.position.x);

        //Cheking distance and enemyStop bool
        if (playerEnemyXDistance < playerEnemyXDistanceMax && enemyStop)
        {
            //Stop
        }
        else
        {
            moveToPlayer = new Vector2(Player.transform.position.x - gameObject.transform.position.x, 0).normalized;  //Vector to the player x position
            transform.Translate(Time.deltaTime * moveToPlayer);
        }
    }
    //cheks if enemy is to shot a missile
    void EnemyMissileAttack()
    {
        if (isShoter)
        {
            GetComponentInChildren<InstansiateMissile>().enabled = true;
        }
    }

}
