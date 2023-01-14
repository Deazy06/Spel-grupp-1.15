using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
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
