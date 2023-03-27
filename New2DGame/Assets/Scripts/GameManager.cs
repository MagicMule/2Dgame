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

    public int Health { get; private set; }

 


    private void Awake()
    {
        //This component gameobjekt to instansiate thoru all sceans
        if (Instance != null)
        {
            DestroyImmediate(gameObject); // �f the compents is in scean, remov it as to not dubbel the gameobjekt
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void OnDestroy() 
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {

    }

    // A new game resets lives and loads level 1 (World 1, stage 1) 
    public void NewGame()
    {
        Health = 3;

        LoadLevel(1, 1);
    }

    public void GameOver()
    {

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

    public void NextWorld()
    {
        LoadLevel(world + 1, 1);
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