using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiofile : MonoBehaviour
{
    Collider2D collide;
    public AudioSource audioSource;
    // Music spelas vid rätt tillfälle - Leon
    private void Start() // När spelaren går in i box trigger så börjar en musikfil spelas, när du går in i den andra så slutar det

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

 