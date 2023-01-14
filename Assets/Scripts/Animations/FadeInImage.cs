using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInImage : MonoBehaviour
{
    private Animator animation;

    public void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void FadeIn(MenuManager menuManager)
    {
        animation.SetTrigger("FadeIn");
    }
}
