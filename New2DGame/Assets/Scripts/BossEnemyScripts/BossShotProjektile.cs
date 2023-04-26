using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShotProjektile : MonoBehaviour
{
    public float fireRate = 3f;
    public float AttackHight = 0.2f;

    public List<GameObject> projektilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstansiateBossAttack", 1, fireRate);
    }

    //Instasate the prefab
    void InstansiateBossAttack()
    {
        // If Boss is on left side -> shot right
        if (transform.position.x < 3.5f)
        {
            Instantiate(projektilePrefab[1], AttackInstasiateLockation(), projektilePrefab[1].transform.rotation);
        }
        // If Boss is on right side -> shot left
        else if (transform.position.x > 3.5f)
        {
            Instantiate(projektilePrefab[0], AttackInstasiateLockation(), projektilePrefab[0].transform.rotation);
        }
    }

    //place were the attack/missile will instansiate
    Vector3 AttackInstasiateLockation()
    {

        Vector3 vectorSpawn = transform.position;
        // If Boss is on left side
        if (transform.position.x < 3.5f)
        {
            vectorSpawn = new Vector3(transform.position.x + 1, transform.position.y + AttackHight, transform.position.z);
        }
        // If Boss is on right side
        else if (transform.position.x > 3.5f)
        {
            vectorSpawn = new Vector3(transform.position.x - 1, transform.position.y + AttackHight, transform.position.z);
        }

        return vectorSpawn;
    }
}
