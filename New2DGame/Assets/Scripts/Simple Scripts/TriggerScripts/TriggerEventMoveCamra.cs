using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventMoveCamra : MonoBehaviour
{
    // The camria with the followplayer script
    public FollowPlayer followPlayerScript;
    public int nivå;
    private void Start()
    {

    }
    // Cange camera focus
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            followPlayerScript.cameraFocus = nivå; // The type of camra controll, from "FollowPLayer" script
            followPlayerScript.UpdateY(); // reset y pos when coliton
        }
    }
}
