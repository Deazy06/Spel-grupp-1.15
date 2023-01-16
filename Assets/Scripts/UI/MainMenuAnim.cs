using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnim : MonoBehaviour
{
    private Animator animation;
    public void Start()
    {
        animation = GetComponent<Animator>();
        animation.SetTrigger("MainFadeIn");

    }

    public void CreditPressed()
    {
        animation.SetTrigger("MainFadeOut");
    }
    public void CreditPressedCredit()
    {
        animation.SetTrigger("MainFadeIn");
    }
}