using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiofile : MonoBehaviour
{
    Collider2D collide;
    public AudioSource audioSource;
    // Music spelas vid r�tt tillf�lle - Leon
    private void Start() // N�r spelaren g�r in i box trigger s� b�rjar en musikfil spelas, n�r du g�r in i den andra s� slutar det

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

 