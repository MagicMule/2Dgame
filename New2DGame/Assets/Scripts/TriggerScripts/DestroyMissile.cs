using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissile : MonoBehaviour
{
    // Destory the players missile if it hits this objekts collidor *This may be better in the playermissile script*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerMissile"))
        {
            Destroy(collision.gameObject);
        }
    }
}
