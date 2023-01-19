using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiofile : MonoBehaviour
{
    Collider2D collide;
    public AudioSource audioSource;

    private void Start()
    {
        collide = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collide.tag == "Player" && !audioSource.isPlaying);
        {
            audioSource.Play();
            collide.enabled = false;
        }
        if (collide.tag == "Player" && audioSource.isPlaying);
        {
            audioSource.Stop();
            collide.enabled = false;
            print("slut");
        }

    }
    
}

 