using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFlip : MonoBehaviour
{
    public EnemyPatrol enemyPatrol;

    // if the Trigger is not touching a Platfomr, turn objekt
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " stoped toutching " + collision.gameObject);
        enemyPatrol.Turn();
    }
}
