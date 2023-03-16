using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator fadeText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        fadeText.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 - scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
    }
}
