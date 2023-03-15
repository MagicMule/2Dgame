using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjektRange : MonoBehaviour
{
    public List<GameObject> fallingRockPrefab;
    public int OutOfBounds = -20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFallingRock", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

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
