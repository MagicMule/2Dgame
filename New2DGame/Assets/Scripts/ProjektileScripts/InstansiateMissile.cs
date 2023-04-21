using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstansiateMissile : MonoBehaviour
{
    /*
     * This repeatedly instantiates an object to be used as missile
     */
    public int missileDely = 2;
    public int missileStart = 1;

    public GameObject missilePrefab;

    void Start()
    {
        InvokeRepeating(nameof(InstansiatMissilePrefab), missileStart, missileDely);
    }
    void InstansiatMissilePrefab()
    {
        Instantiate(missilePrefab, transform.position, transform.rotation); // instansiat at perent; The enemy that shots missile
    }
}
