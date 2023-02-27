using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamge : MonoBehaviour
{
    public int playerPushBackMagnitude = 40;
    public GameManagerSS gameManagerScript;

    void Start()
    {

    }
    private void Update()
    {

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Missile"))
        {
            gameManagerScript.UpdatePlayerHPUI();

        }
        
    } 

}
