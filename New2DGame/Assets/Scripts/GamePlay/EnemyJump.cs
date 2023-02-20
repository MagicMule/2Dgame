using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    public float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb= GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(Jump), 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Jump()
    {
        enemyRb.AddForce(new Vector2(0, 1) * jumpForce, ForceMode2D.Impulse);
    }
}
