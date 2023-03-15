using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissileAtTarget : MonoBehaviour
{
    public GameObject player ;

    public int fireMode = 2;
    public float missileSpeed = 1f;
    public Vector3 targetPos;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        GetTargetPos();
    }
    // Update is called once per frame
    void Update()
    {
        // Missile follow Player
        if (fireMode == 1)
        {
            ShotHoming();
        }
        else if (fireMode == 2)
        // Missile shot att curetnt player pos
        {
            ShotAtPos();
        }
    }
    // get the curent pos of player
    Vector3 GetTargetPos()
    {
        targetPos = (player.transform.position - transform.position).normalized;
        return targetPos;

    }
    void ShotHoming()
    {
        transform.Translate(GetTargetPos() * Time.deltaTime * missileSpeed);
    }
    void ShotAtPos()
    {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(targetPos, ForceMode2D.Impulse); // force based missle
        transform.Translate(targetPos * Time.deltaTime * missileSpeed);
    }
}
