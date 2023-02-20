using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySword : MonoBehaviour
{
    public bool swordAttack;
    // Start is called before the first frame update
    void Start()
    {
        swordAttack = GameObject.Find("PlayerAttack").GetComponent<PlayerAttack>().swordAttackReady;
    }

    // Update is called once per frame
    void Update()
    {
        if (swordAttack == false)
        {
            Debug.Log("Sword destroyed");
        }
    }
}
