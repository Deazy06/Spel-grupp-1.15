using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeInUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    [SerializeField] public bool fadeIn = false;
    [SerializeField] public bool fadeOut = false;
    [SerializeField] public bool fadeOutFaster = false;

    public void FadeOut(MenuManager menuManager)
    {
        fadeOut = true;
    }

    public void FadeOutFaster()
    {
        fadeOutFaster = true;
    }

    public void Start()
    {
        myUIGroup.alpha = 0f;
        fadeIn = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fadeIn)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += 0.009f;
                if (myUIGroup.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
        if (fadeOut)
        {
            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= 0.008f;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
        if (fadeOutFaster)
        {
            if (myUIGroup.alpha >= 0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }

    
}
