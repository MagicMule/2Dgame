using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivateGameObjekts : MonoBehaviour
{
    public GameObject centerPointEnemyTrigg;

    public GameObject enemyWave;

    public GameObject BossDoor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemyWave.SetActive(true);
            centerPointEnemyTrigg.SetActive(true);
            BossDoor.SetActive(true);
        }
    }
}
