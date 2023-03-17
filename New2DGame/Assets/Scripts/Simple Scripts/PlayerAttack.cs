using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject sword;
    public GameObject missile;

    public bool swordAttackReady = true;

    public float swordAttackDeley = 0.5f;
    void Start()
    {
        swordAttackReady = true;
    }
    void Update()
    {
        UseSwordAttack();
        ShotMissile();
    }

    //Attack with the gameobjekt "Sword"
    void UseSwordAttack()
    {
        // if K is presed when swordAttackReady is true, create the sword gameobjekt and start "SwordAttack"
        if (Input.GetKeyDown(KeyCode.K) && swordAttackReady)
        {

            sword.SetActive(true);
            StartCoroutine(SwordAttack());
        }
    }
    // Instansate Missile, att missle prefab postion
    void ShotMissile()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(missile, transform.position + new Vector3(0.5f, 0, 0), transform.rotation);
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
