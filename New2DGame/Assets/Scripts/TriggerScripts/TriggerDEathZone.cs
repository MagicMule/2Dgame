using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDEathZone : MonoBehaviour
{
    // The colider this script is atached to will on colliton game over player objekt, destroy enemy and missile objekt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GetCurentScene();
            GameManager.Instance.GameOver();
        }

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
        }

    }
}
