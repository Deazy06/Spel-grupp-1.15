using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsOverlay : MonoBehaviour
{

     public void OpenOverlay()
    {
        gameObject.SetActive(true);
    }
    public void CloseOverlay()
    {
        gameObject.SetActive(false);
    }

    public void LoadSettingsScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Settings");

    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("DiyorMenu");
        Time.timeScale = 1;

    }   
    public void BackToGame()
    {   
        SceneManager.LoadScene("Diyor");
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
