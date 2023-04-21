using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPowerUp : MonoBehaviour
{
    /*
     * Player picks upp key.
     * The Key is a bool value saved in GameManager.
     * The player have a key or do not.
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GetKey();
            Debug.Log("key is set to " + GameManager.Instance.Key);

            Destroy(gameObject);
        }
    }
}
