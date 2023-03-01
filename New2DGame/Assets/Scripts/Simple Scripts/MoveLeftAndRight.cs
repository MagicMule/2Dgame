using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{

    [SerializeField]
    private float frequency;
    [SerializeField]
    private float waveLength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GoLaftOrRight();
    }
    void GoLaftOrRight()
    {
        transform.localPosition = new Vector3(Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength, 0, 0);
    }
}
