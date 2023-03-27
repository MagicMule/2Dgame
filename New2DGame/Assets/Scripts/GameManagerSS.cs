using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManagerSS : MonoBehaviour
{
    public TextMeshProUGUI playerHPText;

    public int playerHP = 1;
    void Start()
    {
        playerHP = GameManager.Instance.Health;
        playerHP = 3;
    }

    void Update()
    {
        if (playerHP <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("SimpleMainMenu");
        }
    }
    public void UpdatePlayerHPUI()
    {
        playerHP = playerHP - 1;
        playerHPText.text = "HP: " + playerHP;
        Debug.Log(playerHP);
    }
}
