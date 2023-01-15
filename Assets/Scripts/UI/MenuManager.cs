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

        FindObjectOfType<FadeInImage>().FadeIn(this);

    }

    public void TurnOffUI() // Credit
    {
        StartCoroutine(waiter2());
        FindObjectOfType<Credits>().CreditFadeIn(this);
    }
    public void TurnOnUI() // Credit
    {
        StartCoroutine(waiter3());
        FindObjectOfType<Credits>().CreditFadeOut(this);
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    IEnumerator waiter() // PLay
    {

        //Wait for 4 seconds
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Diyor");
        
    }
    IEnumerator waiter2()
    {
        
        yield return new WaitForSeconds(1.1f);
        FindObjectOfType<MainMenu>().Fade(this);
        StopCoroutine(waiter2());
    }
    IEnumerator waiter3()
    {
        FindObjectOfType<MainMenu>().FadeIn(this);
        yield return new WaitForSeconds(1f);
        StopCoroutine(waiter3());

    }
}
