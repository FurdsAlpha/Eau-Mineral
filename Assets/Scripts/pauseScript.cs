using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
    public GameObject menu;
    public bool isPaused = false;
    public void OnPause()
    {
        Pause();
    }

    public void Pause()
    {
        if (isPaused)//Si le jeu est deja en pause
        {
            menu.SetActive(false);//Désactive L'ui du menu pause
            isPaused = false;//Enregistre que le jeu n'est plus en pause
            Time.timeScale = 1;//Le temp s'ecoule normalement
        }
        else
        {
            menu.SetActive(true);//Active L'ui du menu pause;
            isPaused = true;//Enregistre que le jeu est en pause
            Time.timeScale = 0;//Stop le temp
        }
    }
}
