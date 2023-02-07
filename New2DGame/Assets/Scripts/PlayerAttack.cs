using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject sword;
    public bool swordAttackReady;

    public float swordAttackDeley = 0.5f;
    void Start()
    {
        swordAttackReady = true;
    }
    void Update()
    {
        UseSwordAttack();
    }

    //Attack with the gameobjekt "Sword"
    void UseSwordAttack()
    {
        // if Space is presed when swordAttackReady is true, activete the sword gameobjekt and start "SwordAttack"
        if (Input.GetKeyDown(KeyCode.K) && swordAttackReady)
        {
            sword.SetActive(true);
            StartCoroutine(SwordAttack());
        }
    }
    // The objekts becomes unactive withen 0.5 secunds.
    IEnumerator SwordAttack()
    {
        swordAttackReady = false;
        yield return new WaitForSeconds(0.2f);
        sword.SetActive(false);
        StartCoroutine(SwordDely());
    }
    //delay befor player can make new attack
    IEnumerator SwordDely()
    {
        yield return new WaitForSeconds(swordAttackDeley);
        swordAttackReady = true;
    }
}
