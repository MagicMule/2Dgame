using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjektileOnHit : MonoBehaviour
{
    /*
     * If this objekt colides with a sword objket is is destroyed. Used on enemy projektiles.
     * Player "Diflekts" enemy projektiles
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("ProjektileHit!");
            Destroy(gameObject);
        }
    }
}
