using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerAttack : MonoBehaviour
{
    /// <summary>
    /// Handel of Player attacks, Sword and missile.
    /// Manage deleay of player attack.
    /// </summary>
    public GameObject sword;

    public Animator attackAnimation;

    private AudioSource playerAoudio;

    //Sword
    public bool swordAttackReady = true;
    public float swordAttackDeley = 0.5f;
    public float swordAttackDuration = 0.2f;
    public AudioClip attackSound;
    public float swordAttackSoundVolume = 1.0f;

    //Missile
    public bool missileAttackReady = true;
    public float missileAttackDeley = 0.5f;
    public float missileAttackDuration = 0.2f;
    public AudioClip missileAttackSound;
    public float missileAttackSoundVolume = 1.0f;
    public GameObject missile;
    public GameObject missileAttackPos;



    void Start()
    {
        playerAoudio = GetComponent<AudioSource>();
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
            playerAoudio.PlayOneShot(attackSound, swordAttackSoundVolume); // Play attack sound
            attackAnimation.SetBool("swordAttack", true); // Enter the sword attack animation

            sword.SetActive(true); // Activate the sword gameobjekt
            StartCoroutine(SwordAttack()); //Start the sword attack deley
        }
    }

    //Time sword objekt is active
    IEnumerator SwordAttack()
    {
        swordAttackReady = false; // Player can not make onother sword attack atm

        yield return new WaitForSeconds(swordAttackDuration); // Time sword objekt is active

        sword.SetActive(false); // Turn of the sword hitbox

        attackAnimation.SetBool("swordAttack", false); // Exsit the sword attack animation

        StartCoroutine(SwordDely()); // Start Sword attack delay countdown
        
    }

    //delay befor player can make new attack
    IEnumerator SwordDely()
    {
        yield return new WaitForSeconds(swordAttackDeley); // Time befor player can make another sword attack
        swordAttackReady = true; // Player can now make onother attack
    }






    // Instansate Missile, att missle prefab postion
    void ShotMissile()
    {
        if (Input.GetKeyDown(KeyCode.L) && missileAttackReady)
        {
            playerAoudio.PlayOneShot(missileAttackSound, missileAttackSoundVolume); // play missila attack soundclip

            attackAnimation.SetBool("spelAttack", true);
            StartCoroutine(MissileAttack());
        }
    }

    // missile instasiate at missileAttackPos
    IEnumerator MissileAttack()
    {
        
        missileAttackReady = false;
        Instantiate(missile, missileAttackPos.transform.position, missileAttackPos.transform.rotation);

        yield return new WaitForSeconds(missileAttackDeley); // Time befor player can make onather missile attack

        missileAttackReady = true;

        attackAnimation.SetBool("spelAttack", false);
    }
}
