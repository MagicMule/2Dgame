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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit!");
            Destroy(gameObject);
        }
    }
}
