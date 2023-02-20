using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int world { get; private set; }
    public int stage { get; private set; }
    public int lives { get; private set; }
    public int cherry { get; private set; }

    public GameObject gameOverUI; // UI element to be seen at gameover
    public float resetDelay = 2f;


    private void Awake()
    {
        //This compnents gameobjekt to instansiate thoru all sceans
        if (Instance != null)
        {
            DestroyImmediate(gameObject); // Íf the compents is in scean, remov it as to not dubbel the gameobjekt
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // (?)
    private void OnDestroy() 
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60; // Set the max framerate to 60

        NewGame();
        FindObjectOfType<PlayerLife>().OnDeath += GameOver;
        gameOverUI.SetActive(false);

    }

    // A new game resets lives and score (cherry) and loads level 1 (World 1, stage 1) 
    public void NewGame()
    {
        lives = 3;
        cherry = 0;

        LoadLevel(1, 1);
    }

    public void GameOver()
    {
        //AudioManager.instance.PlaySound2D("GameOver");
        gameOverUI.SetActive(true); // Activate the game Over screan

        NewGame(); // Cange to a new game
    }

    // Loding difrent scenes based on world and stage
    public void LoadLevel(int world, int stage)
    {
        this.world = world;
        this.stage = stage;

        SceneManager.LoadScene($"{world}-{stage}"); //load scene
    }

    public void NextLevel()
    {
        LoadLevel(world, stage + 1); //Stay in curent world and load nex stage
    }

    public void ResetLevel(float resetdelay)
    {
        Invoke(nameof(ResetLevel), resetdelay);
    }

    //resets the curent scene
    public void ResetLevel()
    {
        lives--; //lose one Life

        // if lives != 0 load the curent world and satge apon reset
        if (lives > 0)
        {
            LoadLevel(world, stage);
        }
        // if lives <= 0 exeute GameOver funktion
        else
        {
            GameOver();
        }
    }

    // Adds Cherry(score)
    public void AddCherry()
    {
        cherry++; // increas the cherry amount by 1

        if (cherry == 100) // if cherry amount = 100, the player gets an extra life, AddLife
        {
            cherry = 0;
            AddLife();
        }
    }

    // Increase life count by 1
    public void AddLife()
    {
        lives++;
    }

    // UI Input
    // onclik funktion, visible in inspector
    public void StartNewGame()
    {
        SceneManager.LoadScene("1-1"); // loads scean; world 1, stage 1
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // loads the MainMenu
    }

}