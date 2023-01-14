using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup MainMenu;

    private Animator animation;
    public void StartGame()
    {

        StartCoroutine(waiter());
        FindObjectOfType<FadeInUI>().FadeOut(this);

        FindObjectOfType<AudioManager>().FadeOutAudio(this);

        FindObjectOfType<FadeInImage>().FadeIn(this);

    }

    public void TurnOffUI()
    {
        StartCoroutine(waiter2());
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

    IEnumerator waiter2()
    {

        yield return new WaitForSeconds(1.1f);
        FindObjectOfType<MainMenu>().Fade(this);

    }
}
