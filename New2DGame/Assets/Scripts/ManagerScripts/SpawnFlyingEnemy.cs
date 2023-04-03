using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlyingEnemy : MonoBehaviour
{
    // this repeatedly spawn enemies at specified location

    public GameObject enemyPrefab;
    private float enemyYSpawnPos;

    // intervel where objekt can spawn
    public float spawnPosYMax = 5f;
    public float spawnPosYMin = 0;

    void Start()
    {
        InvokeRepeating(nameof(EnemySpawnPos), 1, 1);
    }
    void EnemySpawnPos()
    {
        GameManager.Instance.SpawnEnemy(enemyPrefab, new Vector2(transform.position.x, transform.position.y + GetRandomSpawn()), transform.rotation);
    }
    float GetRandomSpawn()
    {
        enemyYSpawnPos = Random.Range(spawnPosYMin, spawnPosYMax);
        return enemyYSpawnPos;
    }
}
