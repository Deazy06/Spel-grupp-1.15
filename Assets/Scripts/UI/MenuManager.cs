using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private Animator animation;
    public void StartGame()
    {

        StartCoroutine(waiter());
        FindObjectOfType<FadeInUI>().FadeOut(this);

        FindObjectOfType<AudioManager>().FadeOutAudio(this);

    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    IEnumerator waiter()
    {

        //Wait for 4 seconds
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Diyor");
        
    }
}
