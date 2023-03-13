using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManagerSS : MonoBehaviour
{
    //public TextMeshProUGUI scoreText;
    public TextMeshProUGUI playerHPText;

    public int score = 0;
    public int playerHP = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.U))
        {
            UpdateScoreUI();
        }
        */
        if (playerHP <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("SimpleMainMenu");
        }
    }
    /*
    public void UpdateScoreUI()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }
    */
    public void UpdatePlayerHPUI()
    {
        playerHP = playerHP - 1;
        playerHPText.text = "HP: " + playerHP;
        Debug.Log(playerHP);
    }
}
