using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveForwardTranslate : MonoBehaviour
{
    [SerializeField]
    private int forwardSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(forwardSpeed * Time.deltaTime, 0, 0);
    }
}
