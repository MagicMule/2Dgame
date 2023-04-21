using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
    /// <summary>
    /// For Moving platforms.
    /// oscillations back and forth centerd on its parets transform component
    /// *may be incueded in "Movetrigg"*
    /// </summary>

    [SerializeField]
    private float frequency;

    [SerializeField]
    private float waveLength;

    void Update()
    {
        GoLaftOrRight();
    }

    void GoLaftOrRight()
    {
        transform.localPosition = new Vector3(Mathf.Sin(2 * Mathf.PI * Time.time * frequency) * waveLength, 0, 0);
    }
}
