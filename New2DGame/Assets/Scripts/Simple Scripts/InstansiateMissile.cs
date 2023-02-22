using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstansiateMissile : MonoBehaviour
{
    public GameObject missilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstansiatMissile), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstansiatMissile()
    {
        Instantiate(missilePrefab);
    }
}
