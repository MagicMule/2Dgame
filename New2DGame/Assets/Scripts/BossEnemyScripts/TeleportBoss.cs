using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBoss : MonoBehaviour
{
    public float teleportDeley = 3f;
    void Start()
    {
        InvokeRepeating(nameof(MoveBossGameObjetk), 2, teleportDeley);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MoveBossGameObjetk()
    {
        transform.position = TeleportPos();
    }
    //Move objet on x
    Vector3 TeleportPos()
    {
        Vector3 placeToMove = transform.position;

        if (transform.position.x != 7 )
        {
            placeToMove = new Vector3(7, transform.position.y, transform.position.z);
        }
        else if (transform.position.x != 0)
        {
            placeToMove = new Vector3(0, transform.position.y, transform.position.z);
        }
        return placeToMove;
    }
}
