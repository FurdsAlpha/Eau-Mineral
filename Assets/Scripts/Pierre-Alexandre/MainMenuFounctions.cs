using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFounctions : MonoBehaviour
{
    public string GameScene;
    public void Start()
    {
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Play()
    {
        SceneManager.LoadScene(GameScene);
    }
}
