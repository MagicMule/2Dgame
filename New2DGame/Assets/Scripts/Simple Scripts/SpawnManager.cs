using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> enemies;

    public float spawnpPos = 0;

    public Vector3 spawnOfset;


    // Start is called before the first frame update

    void Start()
    {
        SpawnPoiton();
        InvokeRepeating(nameof(SpawnEnemy), 1, 2); // repeting waves of enemys
    }

    // spawns all gameobjekts in enemis list
    public void SpawnEnemy()
    {
        foreach (GameObject enemy in enemies)
        {
            Instantiate(enemy,transform.position + spawnOfset, transform.rotation);
        }
    }

    // ofset from spawnmanger centrum
    public Vector3 SpawnPoiton()
    {
       spawnOfset = new Vector3(0, 0, 0);
       return spawnOfset;
    }

}
