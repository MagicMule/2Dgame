using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissileAtTarget : MonoBehaviour
{
    public GameObject player;
    public float missileSpeed = 1f;
    public Vector3 targetPos;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(GetTargetPos() * Time.deltaTime * missileSpeed);
    }
    Vector3 GetTargetPos()
    {
        targetPos = (player.transform.position - transform.position).normalized;
        return targetPos;

    }
}
