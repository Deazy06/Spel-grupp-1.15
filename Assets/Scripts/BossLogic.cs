using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    bool start = false;
    [SerializeField] GameObject location;
    [SerializeField] GameObject boss;
    [SerializeField] GameObject player;
    [SerializeField] GameObject box;
    [SerializeField] GameObject macka;
    [SerializeField] GameObject laser;
    [SerializeField] SpriteRenderer deathCheck;
    [SerializeField] int randomizer;
    Collider2D collide;

    public AudioSource bossaudio;

    float timer;
    float timer1;
    float deathTimer;

    void Start()
    {
        collide = GetComponent<Collider2D>();
        location = GameObject.Find("SpawnLocation");

    }

    // Update is called once per frame
    void Update()
    {
        if (start == true) //n�r start sant, s�tts timer som startar om efter ca 2 sek - Noel
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 2)
            {
                timer = 0; // varje 2sek anv�nds funktionen RandomizeATK och death-timern �kar - Noel
                RandomizeATK();
                deathTimer += 1;
                if (deathTimer == 25) // n�r deathtimern n�r 25 s� skapas en l�da lite framf�r location objekted (�ver bossen) - Noel
                {
                    Instantiate(box, location.transform.position + new Vector3(3.5f, 0, 0), transform.rotation);
                }
                else if (deathTimer == 26) // n�r deathtimern n�r 26 startar timers om och avslutas, start �r false allts� slutar bossen g�ra n�nting och musik stoppas - Noel
                {
                    timer = 0;
                    deathTimer = 0;
                    bossaudio.Stop();
                    start = false;

                }
            }
         
        }

        deathCheck = GameObject.Find("Player").GetComponent<SpriteRenderer>(); // Deathcheck kollar n�r spelaren �r transparant - Noel
        if (deathCheck.color == new Color(0, 0, 0, 0))
        {
            // timers �terst�lls, bossens slutar g�ra n�nting, musiken slutar och bosstriggerns collider s�tts p� s� att bossen kan startas om - Noel
            timer = 0; 
            deathTimer = 0;
            start = false;
            collide.enabled = true;
            bossaudio.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // n�r spelaren g�r genom boss triggern: st�ngs trigger collidern av, bossen startas, musiken startas - Noel
    {
        if (collision.gameObject.tag == "Player")
        {
            collide.enabled = false;
            start = true;
            bossaudio.Play();
        }


    }
    private void RandomizeATK() // funktionen slumpar en av 3 attacker och anv�nder laser funktionen - Noel
    {
        Laser();
        randomizer = Random.Range(1, 4); 
        if (randomizer == 1) // ATK1: skapar en macka slumpat y-v�rde - Noel
        {
            Instantiate(macka, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);
        }
        else if (randomizer == 2) // ATK2: skapar en l�da �ver spelaren - Noel
        {
            player = GameObject.Find("Player");
            Instantiate(box, player.transform.position + new Vector3(0, 10, 0), transform.rotation);
            
        }
        else if (randomizer == 3) // ATK3: skapar 3 l�dar vid slumpat y-v�rde - Noel
        { 
            for (int i = 0; i < 3; i++)
            {
                Instantiate(box, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);
                
            }


        }

    }
    private void Laser() //bildar laser vid typ bossens �gon - Noel
    {
        Instantiate(laser, boss.transform.position + new Vector3(0, 2.2f, 0), transform.rotation);
    }




}
