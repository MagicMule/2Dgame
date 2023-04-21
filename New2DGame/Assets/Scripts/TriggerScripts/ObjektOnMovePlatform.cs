using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektOnMovePlatform : MonoBehaviour
{
    // Objekt on colliton will follow this gameobjekt

    /*
     * The coliding objekt will share the same transform norm as the moving platfrom.
     * As long as the objekt is in coliton with the platform its transforms parent will
     * be that of the platform rather then is original
     */

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            collision.gameObject.transform.parent = transform; // get colliding object transform to be the same as this objekts transform
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
