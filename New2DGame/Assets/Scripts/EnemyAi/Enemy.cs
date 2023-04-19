using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    private GameObject player;


    public AudioSource playerAudio; //The AudioSurce on the player objekt

    public AudioClip enemyGetHitByPlayerSound;

    public float pushDistanse = 10f;
    public int enemyHealth = 10;
    public float enemySpeed = 5;

    private Vector3 moveToPlayer;

    public bool isShoter = false; // if enemy is to shot
    public bool enemyStop = false; // if enemy is to stop at distace
    public bool enemyMoveTo = true; // if enemy is to move to player

    private float playerEnemyXDistance;
    public float playerEnemyXDistanceMax = 3;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

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
        if (collision.gameObject.CompareTag("Sword") || collision.gameObject.CompareTag("PlayerMissile"))
        {
            playerAudio.PlayOneShot(enemyGetHitByPlayerSound, 1.0f); //play when enemy is hit

            Debug.Log(collision.gameObject.name + " hit " + gameObject.name);
            enemyHealth -= 1;

            // Push enemy up and away from attack
            enemyRb.AddForce(new Vector2((gameObject.transform.position.x - player.transform.position.x), 1).normalized * pushDistanse, ForceMode2D.Impulse);

            if (collision.gameObject.CompareTag("PlayerMissile")) // if hit by missile, destriy missile
            {
                Destroy(collision.gameObject);
            }

            // Destroy enemy if no more health
            if (enemyHealth <= 0)
            {

                Debug.Log("Enemy destroyed: " + gameObject.name);
                Destroy(gameObject);
            }

        }


    }

    //Movinge to player on X
    void EnemyMoveToPlayer()
    {
        if(enemyMoveTo)
        {
            //Disdance form player and enemy on the X axes
            playerEnemyXDistance = Mathf.Abs(player.transform.position.x - gameObject.transform.position.x);

            //Cheking distance and enemyStop bool
            if (playerEnemyXDistance < playerEnemyXDistanceMax && enemyStop)
            {
                //Stop
            }
            else
            {
                moveToPlayer = new Vector2(player.transform.position.x - gameObject.transform.position.x, 0).normalized;  //Vector to the player x position
                transform.Translate(Time.deltaTime * moveToPlayer);
            }
        }


    }
    //cheks if enemy is to shot missile
    void EnemyMissileAttack()
    {
        if (isShoter)
        {
            GetComponentInChildren<InstansiateMissile>().enabled = true;
        }
    }

}
