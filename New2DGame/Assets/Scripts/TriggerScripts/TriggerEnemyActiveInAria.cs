using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerEnemyActiveInAria : MonoBehaviour
{
    /*
     * Acrivate the enemy screapt, and sprite of enemys,
     * in an aria made of collidors around the player
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enabled = true;
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
