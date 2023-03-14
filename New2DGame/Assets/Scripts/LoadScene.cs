using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{

    public string sceneToLoad;
    AsyncOperation loadingOperation;
    public Text percentLoaded;

    void Start()
    {
        loadingOperation = SceneManager.LoadSceneAsync(sceneToLoad);
    }
    void Update()
    {
        float progressValue = Mathf.Clamp01(loadingOperation.progress / 0.9f);
        percentLoaded.text = Mathf.Round(progressValue * 100) + "%";
    }

}