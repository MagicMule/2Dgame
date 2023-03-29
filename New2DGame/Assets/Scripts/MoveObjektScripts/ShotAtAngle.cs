using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAtAngle : MonoBehaviour
{
    private Rigidbody2D rB;
    private Vector2 objektDir;

    public Transform placeToShotFrom;

    public int moveSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(placeToShotFrom.position * moveSpeed);
    }

    Vector2 VectorOfObjetkToBeShot(Vector2 movePath)
    {
        movePath = new Vector2(placeToShotFrom.position.x, placeToShotFrom.position.y).normalized;
        return movePath;
    }
}
