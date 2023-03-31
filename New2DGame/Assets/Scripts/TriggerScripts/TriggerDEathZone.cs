using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDEathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }

        if ( collision.gameObject)
        {
            Destroy(collision.gameObject);
        }


    }
}
