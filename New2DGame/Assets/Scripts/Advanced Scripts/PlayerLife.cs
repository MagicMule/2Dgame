using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    

    public float startingHealth;
    public float health { get; protected set; }
    protected bool dead; // checking player death status

    public event System.Action OnDeath;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    public void Hit()
    {
        Death();
    }

    public void Death()
    {
        
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");

        //AudioManager.instance.PlaySound("PlayerDeath", transform.position);

        GameManager.Instance.ResetLevel(4f);
        FindObjectOfType<GameManager>().GameOver();
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {

            Death();
            FindObjectOfType<AudioManager>().Play("PlayerDeath");


        }
    }

    public virtual void Die()
    {
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }
        GameObject.Destroy(gameObject);


    }


}