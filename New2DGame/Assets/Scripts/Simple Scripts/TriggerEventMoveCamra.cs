using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventMoveCamra : MonoBehaviour
{
    // The camria with the followplayer script
    public FollowPlayer followPlayerScript;

    private void Start()
    {

    }
    // Cange camera focus
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            followPlayerScript.cameraFocus = 2;
        }
    }
}
