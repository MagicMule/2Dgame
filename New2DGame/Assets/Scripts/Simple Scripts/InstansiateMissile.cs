using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InstansiateMissile : MonoBehaviour
{
    public int missileDely = 2;
    public GameObject missilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(InstansiatMissilePrefab), 1, missileDely);
    }
    void InstansiatMissilePrefab()
    {
        Instantiate(missilePrefab, transform.position, transform.rotation); // instansiat at perent; The enemy that shots missile
    }
}
