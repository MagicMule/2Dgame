using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemyActiveInAria : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enabled = true;
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
