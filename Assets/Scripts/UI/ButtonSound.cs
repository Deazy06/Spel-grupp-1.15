using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour // Diyor Spelar upp ljud när man hover över knappen
{

    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
        mySounds.PlayOneShot (hoverSound);
    }

    public void ClickSound()
    {
        mySounds.PlayOneShot (clickSound);
    }

}
