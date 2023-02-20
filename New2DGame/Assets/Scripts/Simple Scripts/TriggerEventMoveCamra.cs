using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventMoveCamra : MonoBehaviour
{
    public FollowPlayer followPlayerScript;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            followPlayerScript.offsetY = collision.transform.position.y; // ändra bara en gång nu...
        }
    }
}
