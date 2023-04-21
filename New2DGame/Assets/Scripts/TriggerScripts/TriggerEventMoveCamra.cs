using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventMoveCamra : MonoBehaviour
{
    // The camera with the followplayer script
    public FollowPlayer followPlayerScript;
    public int nivå;

    // Cange camera focus
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            followPlayerScript.cameraFocus = nivå; // The type of camra controll, from "FollowPLayer" script
            followPlayerScript.UpdateY(); // reset y pos when collision
        }
    }
}
