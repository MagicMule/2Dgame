using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDEathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player gameobjekt is to be destoryed" + collision.gameObject.name + " Destroyed");
            GameManager.Instance.GameOver();
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Other gameobjekt is to be destroyed: " + collision.gameObject.name + " Destroyed");
            Destroy(collision.gameObject);
        }

    }
}
