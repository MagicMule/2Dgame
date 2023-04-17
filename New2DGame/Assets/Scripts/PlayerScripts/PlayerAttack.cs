using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerAttack : MonoBehaviour
{
    public GameObject sword;

    public Animator attackAnimation;

    public GameObject missile;
    public GameObject missileAttackPos;

    public bool swordAttackReady = true;
    public float swordAttackDeley = 0.5f;

    public bool missileAttackReady = true;
    public float missileAttackDeley = 0.5f;


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
            attackAnimation.SetBool("swordAttack", true); // Enter the sword attack animation
            sword.SetActive(true);
            StartCoroutine(SwordAttack());
        }
    }

    //This instasate the sword for 0.2 sec and then starts SwordDeley
    IEnumerator SwordAttack()
    {
        swordAttackReady = false; 
        yield return new WaitForSeconds(0.2f); //The sword objekt is active for 0.2 sec
        sword.SetActive(false);
        StartCoroutine(SwordDely());
        attackAnimation.SetBool("swordAttack", false); // Exsit the sword attack animation
    }

    //delay befor player can make new attack
    IEnumerator SwordDely()
    {
        yield return new WaitForSeconds(swordAttackDeley);
        swordAttackReady = true;
    }






    // Instansate Missile, att missle prefab postion
    void ShotMissile()
    {
        if (Input.GetKeyDown(KeyCode.L) && missileAttackReady)
        {
            attackAnimation.SetBool("spelAttack", true);
            StartCoroutine(MissileAttack());
        }
    }

    // missile instasiate at missileAttackPos
    IEnumerator MissileAttack()
    {
        
        missileAttackReady = false;
        Instantiate(missile, missileAttackPos.transform.position, missileAttackPos.transform.rotation);
        yield return new WaitForSeconds(missileAttackDeley);
        missileAttackReady = true;

        attackAnimation.SetBool("spelAttack", false);
    }
}
