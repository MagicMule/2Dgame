using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void StartGame()
    {
        SceneManager.LoadScene("1-2");
    }
}
