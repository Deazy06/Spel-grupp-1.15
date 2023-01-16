using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using JetBrains.Annotations;

public class Inventory : MonoBehaviour // Diyor made this lol
{
    public GameObject shopMenuUI;
    private int toggle;
    void Start()
    {
        shopMenuUI.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            this.toggle += 1;
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

        if (toggle == 4)
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
    }
}
