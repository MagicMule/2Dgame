using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerNextLevel : MonoBehaviour
{
    // trigger that loads next scene

    public bool nextLevel;
    public bool nextWorld;
    public bool finalLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //load next level
        if (collision.CompareTag("Player") && nextLevel)
        {
            Debug.Log(GameManager.Instance.world + "-" + GameManager.Instance.stage);
            GameManager.Instance.NextLevel();
        }
        else if (collision.CompareTag("Player") && nextWorld)
        // load level 1 of next world
        {
            GameManager.Instance.NextWorld();
        }
        else if(collision.CompareTag("Player") && finalLevel)
        {
            GameManager.Instance.LoadLevelName("0-0");
        }
    }
}
