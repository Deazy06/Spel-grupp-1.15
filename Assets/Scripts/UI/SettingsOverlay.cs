using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsOverlay : MonoBehaviour
{
    /*
    public void OpenOverlay()
    {
        gameObject.SetActive(true);
    }
    public void CloseOverlay()
    {
        gameObject.SetActive(false);
    }
    */

    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("DiyorMenu");
    }
}
