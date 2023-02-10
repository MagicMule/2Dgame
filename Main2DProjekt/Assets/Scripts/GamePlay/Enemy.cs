using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    public GameObject Player;
    public float pushDistanse = 10f;
    public int enemyHealth = 10;
    public float enemySpeed = 5;
    private Vector3 moveToPlayer;

    public bool enemyStop = false;
    private float playerEnemyXDistance;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        EnemyMoveToPlayer();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("Player hit: " + gameObject.name);
            enemyHealth -= 1;
            Debug.Log("Enemy Health left: " + enemyHealth);
            // Push enemy up and away from attack
            enemyRb.AddForce(new Vector2((gameObject.transform.position.x - Player.transform.position.x), 1).normalized * pushDistanse, ForceMode2D.Impulse);

        }
        if (enemyHealth <= 0)
        {
            Debug.Log("Enemy destroyed: " + gameObject.name);
            Destroy(gameObject);
        }

    }
    void EnemyMoveToPlayer()
    {
        //avstånd mellan enemy och player
        playerEnemyXDistance = Mathf.Abs(Player.transform.position.x - gameObject.transform.position.x);

        // Då avståndet är störe en och enemyStop inte är sant så rör sig enemy spelare
        if (playerEnemyXDistance < 5 && enemyStop)
        {
            //Stop
        }
        else
        {
            //Vector to the player x position
            moveToPlayer = new Vector2(Player.transform.position.x - gameObject.transform.position.x, 0).normalized;
            transform.Translate(Time.deltaTime * moveToPlayer);
        }
    }

}
