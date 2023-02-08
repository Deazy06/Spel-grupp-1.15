using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnim : MonoBehaviour // Diyor Animations för maainMenu
{
    private Animator animation;
    public void Start()
    {
        animation = GetComponent<Animator>();
        animation.SetTrigger("MainFadeIn");

    }
    public void SettingsPressed()
    {
        animation.SetTrigger("MainFadeOut");
    }
    public void SettingsPressedSettings()
    {
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
    public void GameStart()
    {
        animation.SetTrigger("MainFadeOut");
    }
}
