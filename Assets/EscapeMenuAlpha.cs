using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuAlpha : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CanvasGroup Canvas;
    [SerializeField] public bool fadeOut;
    [SerializeField] public bool fadeIn;
    public void FadeOut()
    {
        fadeOut = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Canvas.alpha = 1;
        }

        if (fadeOut)
        {
            if (Canvas.alpha >= 0)
            {
                Canvas.alpha -= Time.deltaTime;
                if (Canvas.alpha == 0)
                {
                    fadeOut = false;
                }

            }
        }
        if (fadeIn)
        {
            if (Canvas.alpha < 1)
            {
                Canvas.alpha += Time.deltaTime;
                if (Canvas.alpha >= 1)
                {
                    fadeIn = false;
                }

            }
        }
    }

}
