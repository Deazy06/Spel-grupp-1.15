using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeInUI : MonoBehaviour
{
    private Animator animation;

    [SerializeField] private CanvasGroup myUIGroup;

    [SerializeField] public bool fadeIn = false;
    [SerializeField] public bool fadeOut = false;
    [SerializeField] public bool fadeInFaster = false;
    [SerializeField] public bool fadeOutFaster = false;
    [SerializeField] public bool fadeInDelayed = false;


    public void FadeOut(MenuManager menuManager)
    {
        fadeOut = true;
    }

    public void FadeOutFaster()
    {
        fadeOutFaster = true;
    }

    public void FadeInFaster()
    {
        fadeInFaster = true;
    }
    public void FadeInDelayed()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        fadeInDelayed = true;
    }
    public void FadeIn()
    {
        //fadeIn = true;
    }

    public void Start()
    {
        
        myUIGroup.alpha = 0f;
        //fadeIn = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (fadeIn || fadeInDelayed)
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
                    fadeOutFaster = false;
                }
            }
        }
        if (fadeInFaster)
        {
            if (myUIGroup.alpha < 1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >= 1)
                {
                    fadeInFaster = false;
                }

            }


        }
    }
}