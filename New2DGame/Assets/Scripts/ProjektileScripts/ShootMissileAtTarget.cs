using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissileAtTarget : MonoBehaviour
{
    /*
     * This is used to find player positon and fire  
     * this objekt at player with homing or non-homing missile.
     */

    public GameObject player;

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
        ShotAttTarget(fireMode);
    }

    // Get a vector pointing to player positon
    Vector3 GetTargetPos()
    {
        targetPos = (player.transform.position - transform.position).normalized;
        return targetPos;
    }

    void ShotHoming()
    {
        transform.Translate(missileSpeed * Time.deltaTime * GetTargetPos());
    }

    void ShotAtPos()
    {
        //gameObject.GetComponent<Rigidbody2D>().AddForce(targetPos, ForceMode2D.Impulse); // force based missle
        transform.Translate(missileSpeed * Time.deltaTime * targetPos);
    }

    void ShotAttTarget(int fireModeToShot)
    {
        fireModeToShot = fireMode;
        // Missile follow Player
        if (fireMode == 1)
        {
            ShotHoming();
        }

        // Missile shot att curetnt player position
        else if (fireMode == 2)
        {
            ShotAtPos();
        }
    }
}
