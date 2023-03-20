using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektOnMovePlatform : MonoBehaviour
{
    // Objekt on colliton will follow this gameobjekt

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            collision.gameObject.transform.parent = transform; // set coliding objekt to follow platfrom
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            collision.gameObject.transform.parent = null; // set exseting objekt to return to orignal transform parent
        }
    }
}
