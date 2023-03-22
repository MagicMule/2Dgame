using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEeventActivateEnemy : MonoBehaviour
{
    // List of enemys to be aktivated by trigger
    public List<Enemy> enemies;
    // When colliton with Player, activate enemyscript in enemy prefabs
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (Enemy enemy in enemies)
            {
                Debug.Log("EventEnemyActivate");
                enemy.gameObject.GetComponentInChildren<Enemy>().enabled = true;
            }

        }
        Destroy(gameObject);

    } 

}
