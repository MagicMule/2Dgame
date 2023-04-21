using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjektRange : MonoBehaviour
{
    /// <summary>
    /// Span falling obkets in aria based on transfrom *Could be more general*
    /// </summary>

    public List<GameObject> fallingRockPrefab;

    void Start()
    {
        InvokeRepeating(nameof(SpawnFallingRock), 1, 1);
    }

    // spawn all falling rocks from list
    void SpawnFallingRock()
    {
        Instantiate(fallingRockPrefab[0], PosToSpawn(), transform.rotation);
        Instantiate(fallingRockPrefab[1], PosToSpawn() + new Vector2 (6, 0), transform.rotation);
        Instantiate(fallingRockPrefab[2], PosToSpawn() + new Vector2 (12, 0), transform.rotation);
    }
    // base spawnpos
    Vector2 PosToSpawn()
    {
        Vector2 spawnPos = new Vector2 (49, 20);
        return spawnPos;
    }
}
