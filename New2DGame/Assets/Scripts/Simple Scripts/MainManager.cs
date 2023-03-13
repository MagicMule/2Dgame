using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
    // Trying to save score
    public static MainManager instance;

    public int score;

    public TextMeshProUGUI highScoreText;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this; 
        DontDestroyOnLoad(gameObject);
    }
    
    /*
    public void UpdateHighScore()
    {
        highScoreText.text = "High Score: " + score;
    }
    */
}
