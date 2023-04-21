using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpenDoor : MonoBehaviour
{
    // if player has key, key bool set to true, the door objekt will be destoryed, key bool is in gamemanager
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && GameManager.Instance.Key)
        {
            Destroy(gameObject);
        }
        
    }
}
