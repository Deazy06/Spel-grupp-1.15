using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

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
        }

        if (toggle == 3)
        {
            shopMenuUI.SetActive(false);
        }

        if (toggle == 4)
        {
            this.toggle = 1;
        }


    }
}
