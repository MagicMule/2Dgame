using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Used to manage status of player and game general.
    /// Values that is needed thou all scenes
    /// Funktons used in button, and other, events
    /// </summary>
    public static GameManager Instance { get; private set; }

    public int world { get; private set; }

    public int stage { get; private set; }

    public int lives { get; private set; }

    public int Health { get; private set; }

    public bool Key { get; private set; }

 


    private void Awake()
    {
        GetCurentScene();
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
        GetCurentScene(); //update the gamanger, when entering a scene in editor
        Debug.Log("The curent Level is: " + world + "-" + stage);
    }

    private void OnDestroy() 
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void Update()
    {
        CheckCurrentScene();
        //GetCurentScene(); // Har fix to keep the level and stage up to date
    }

    void CheckCurrentScene()
    {
        //Manual check for curent level
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetCurentScene(); // updat world and stage
            Debug.Log("Current world and stage: " + world + "-" + stage);

        }
    }

    //Updartes the World and level integers
    public void GetCurentScene()
    {
        if (SceneManager.GetActiveScene().name == "1-1")
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
        else if (SceneManager.GetActiveScene().name == "0-0") // final
        {
            world = 0;
            stage = 0;
        }
    }

    // A new game resets lives and loads level 1 (World 1, stage 1) 
    public void NewGame()
    {
        //Upddate World and Stage
        world = 1;
        stage = 1;

        Health = 3;

        LoadLevel(1, 1);
    }

    public void GoToIntroScene()
    {
        LoadLevelName("IntroText");
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
        GetCurentScene(); //update the gamanger, when entering a scene in editor

        Debug.Log(world + "-" + stage);
        Debug.Log(SceneManager.GetActiveScene().name);

        LoadLevel(world, stage + 1); //Stay in curent world and load nex stage
    }

    // Load next world at stage 1
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

    // loads the MainMenu
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    // Load sceane based on name
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