using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour // Fadear ut audion n�r man trycker p� Play i MainMenu
{
    private Animator animation;

    public void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void FadeOutAudio(MenuManager menuManager)
    {
        animation.SetTrigger("FadeOutAudio");
    }

}
