using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlyingEnemy : MonoBehaviour
{
    /// <summary>
    /// This repeatedly spawn objekts in a Random interval
    /// </summary>

    public GameObject enemyPrefab;
    private float enemyYSpawnPos;

    public float startSpawning = 1.0f;
    public float reapetSpawningRate = 1.0f;

    // intervel where objekt can spawn
    public float spawnPosYMax = 5f;
    public float spawnPosYMin = 0;

    void Start()
    {
        InvokeRepeating(nameof(EnemySpawnPos), startSpawning, reapetSpawningRate);
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
