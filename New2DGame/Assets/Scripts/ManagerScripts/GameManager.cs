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

    public bool Key { get; private set; }

 


    private void Awake()
    {
        //This component gameobjekt to instansiate thoru all sceans
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
    private void OnDestroy() 
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    //update the gamanger, when entering a scene in editor
    private void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        GetCurentScene();
    }

    //Updartes the World and level integers
    public void GetCurentScene()
    {
        if(SceneManager.GetActiveScene().name == "1-1")
        {
            world = 1;
            stage = 1;
        }
        else if (SceneManager.GetActiveScene().name == "1-2")
        {
            world = 1;
            stage = 2;
        }
        else if (SceneManager.GetActiveScene().name == "1-3")
        {
            world = 1;
            stage = 3;
        }
        else if (SceneManager.GetActiveScene().name == "2-1")
        {
            world = 2;
            stage = 1;
        }
        else if (SceneManager.GetActiveScene().name == "2-2")
        {
            world = 2;
            stage = 2;
        }
        else if (SceneManager.GetActiveScene().name == "2-3")
        {
            world = 2;
            stage = 3;
        }
        else if (SceneManager.GetActiveScene().name == "3-1")
        {
            world = 3;
            stage = 1;
        }
        else if (SceneManager.GetActiveScene().name == "3-2")
        {
            world = 3;
            stage = 2;
        }
        else if (SceneManager.GetActiveScene().name == "3-3")
        {
            world = 3;
            stage = 3;
        }
    }

    // A new game resets lives and loads level 1 (World 1, stage 1) 
    public void NewGame()
    {
        Health = 3;

        LoadLevel(1, 1);
    }

    public void GameOver()
    {

        //NewGame(); // Cange to a new game
        LoadLevel(world, stage); // restart/load curent level
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
    public void LoadLevelName(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    // when player pick upp key
    public void GetKey()
    {
        Key = true;
    }

    //Spawn a gameobjet att lokation
    public void SpawnEnemy(GameObject enemy, Vector2 spawnPos, Quaternion rotationDeg)
    {
        Instantiate(enemy, spawnPos, rotationDeg);
    }

}