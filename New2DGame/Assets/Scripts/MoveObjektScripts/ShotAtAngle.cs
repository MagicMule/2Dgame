using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAtAngle : MonoBehaviour
{
    /// <summary>
    /// To shot an objekt at designated angel and positon
    /// To be used in 2d plane
    /// </summary>
    ///

    private Rigidbody2D rB;
    private Vector2 objektDir;

    public Vector2 placeToShotFrom;

    public int moveSpeed = 10;


    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(VectorOfObjetkToBeShot(placeToShotFrom) * moveSpeed);
    }

    Vector2 VectorOfObjetkToBeShot(Vector2 movePath)
    {
        movePath = new Vector2(placeToShotFrom.x, placeToShotFrom.y).normalized;
        return movePath;
    }
}
