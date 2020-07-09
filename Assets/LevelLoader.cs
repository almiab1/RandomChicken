using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadigScreen;
    public Slider slider;
    public Canvas playerCanvas;
    public void LoadLevel (int sceneIndex)
    {
        Debug.Log("LoadLevel start");
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Debug.Log("LoadLevel end");
        playerCanvas.enabled = false;
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadigScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }

    }
}
