using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstansiateMissile : MonoBehaviour
{
    public GameObject missilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstansiatMissilePrefab), 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstansiatMissilePrefab()
    {
        Instantiate(missilePrefab, transform.position, transform.rotation); // instansiat at perent; The enemy that shots missile
    }
}
