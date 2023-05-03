using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerHealthManager : MonoBehaviour
{
    /// <summary>
    /// Handel health value and display in canvis
    /// Health variable from Gamemangaer
    /// </summary>

    public TextMeshProUGUI playerHPText;

    public int playerHP;
   

    // Get the Player health value from gamemanger
    void Start()
    {
        playerHP = GameManager.Instance.Health;
        playerHP = 3;
    }

    // Call gameover funkton from Gamemanager when playerhp is 0 
    void Update()
    {
        if (playerHP <= 0)
        {
            Debug.Log("Game Over!");
            GameManager.Instance.GetCurentScene();
            GameManager.Instance.GameOver();
        }
    }

    // Uppdat the curent hp value *culd mod to be able to increased Hp*  
    public void UpdatePlayerHPUI()
    {
        playerHP = playerHP - 1; // Uppdate variable
        playerHPText.text = "HP: " + playerHP; // uppdate desplay text
        Debug.Log(playerHP);
    }
}
