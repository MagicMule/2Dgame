using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjektileOnHit : MonoBehaviour
{
    /*
     * If this objekt colides with a sword objket is is destroyed. Used on enemy projektiles.
     * Player "Diflekts" enemy projektiles
     */
    public AudioSource PlayerAudio;
    public AudioClip projektileDestroySound;
    public float destroySoundVolume = 1.0f;

    private GameObject playerGameObjekt;

    private void Start()
    {
        playerGameObjekt = GameObject.FindGameObjectWithTag("Player");
        PlayerAudio = playerGameObjekt.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("ProjektileHit!");
            PlayerAudio.PlayOneShot(projektileDestroySound, destroySoundVolume);
            Destroy(gameObject);
        }
    }
}
