using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameToSettings : MonoBehaviour
{
    public GameObject shopMenuUI;
    private int toggle;
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] public bool fadeIn = false;

    void Start()
    {
        shopMenuUI.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            fadeIn = true;
            this.toggle += 1;
            if (fadeIn)
            {
                if (myUIGroup.alpha < 1)
                {
                    myUIGroup.alpha += 1f;
                    if (myUIGroup.alpha >= 1)
                    {
                        fadeIn = false;
                    }
                }
            }
        }

        if (toggle == 1)
        {
            shopMenuUI.SetActive(true);

            this.toggle += 1;

            PauseGame();
        }

        if (toggle == 3)
        {
            shopMenuUI.SetActive(false);
            ResumeGame();
        }

        if (toggle == 3)
        {
            this.toggle = 1;
        }





    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
       //toggle += 1;
    }
}
