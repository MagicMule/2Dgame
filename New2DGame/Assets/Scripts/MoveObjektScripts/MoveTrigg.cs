using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MoveTrigg : MonoBehaviour
{
    /// <summary>
    /// Apply general tregonometrik movement on objekt
    /// Cerkular movement or up and down movement
    /// </summary>

    [SerializeField]
    public float frequency = 1.0f;

    [SerializeField]
    public float waveLength = 1.0f;

    [SerializeField]
    public bool CircleOn = false;

    [SerializeField]
    public bool upDownOn = false;

    void Update()
    {
        if (CircleOn)
        {
            TriggMovmentCircle();
        }
        else if (upDownOn)
        {
            TriggMovmentUpDown();
        }
    }

    void TriggMovmentCircle()
    {
        transform.localPosition = new Vector3(Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength,
                                              Mathf.Cos(2 * Mathf.PI * Time.time * frequency) * waveLength,
                                              0);                                                            //"Time.time" is a varibal that canges over time, an so changes positon
    }

    void TriggMovmentUpDown()
    {
        transform.localPosition = new Vector3(0, Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength, 0);
    }
}
