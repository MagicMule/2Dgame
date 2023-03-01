using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MoveTrigg : MonoBehaviour
{
    [SerializeField]
    private float frequency = 1.0f;

    [SerializeField]
    private float waveLength = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TriggMovment();
    }
    void TriggMovment()
    {
        transform.localPosition = new Vector3(Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength,
                                         Mathf.Cos(2 * Mathf.PI * Time.time * frequency) * waveLength,
                                         0);                                                            //"Time.time" is a varibal that canges over time, an so changes positon
    }
}
