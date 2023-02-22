using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissileAtTarget : MonoBehaviour
{
    public GameObject target;
    public float missileSpeed = 1f;
    public Vector3 targetPos;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GetTargetPos() * Time.deltaTime * missileSpeed);
    }
    Vector3 GetTargetPos()
    {
        targetPos = (target.transform.position - transform.position).normalized;
        return targetPos;

    }
}
