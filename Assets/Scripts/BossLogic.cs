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
        if (start == true) //när start sant, sätts timer som startar om efter ca 2 sek - Noel
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 2)
            {
                timer = 0; // varje 2sek används funktionen RandomizeATK och death-timern ökar - Noel
                RandomizeATK();
                deathTimer += 1;
                if (deathTimer == 25) // när deathtimern når 25 så skapas en låda lite framför location objekted (över bossen) - Noel
                {
                    Instantiate(box, location.transform.position + new Vector3(3.5f, 0, 0), transform.rotation);
                }
                else if (deathTimer == 26) // när deathtimern når 26 startar timers om och avslutas, start är false alltså slutar bossen göra nånting och musik stoppas - Noel
                {
                    timer = 0;
                    deathTimer = 0;
                    bossaudio.Stop();
                    start = false;

                }
            }
         
        }

        deathCheck = GameObject.Find("Player").GetComponent<SpriteRenderer>(); // Deathcheck kollar när spelaren är transparant - Noel
        if (deathCheck.color == new Color(0, 0, 0, 0))
        {
            // timers återställs, bossens slutar göra nånting, musiken slutar och bosstriggerns collider sätts på så att bossen kan startas om - Noel
            timer = 0; 
            deathTimer = 0;
            start = false;
            collide.enabled = true;
            bossaudio.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // när spelaren går genom boss triggern: stängs trigger collidern av, bossen startas, musiken startas - Noel
    {
        if (collision.gameObject.tag == "Player")
        {
            collide.enabled = false;
            start = true;
            bossaudio.Play();
        }


    }
    private void RandomizeATK() // funktionen slumpar en av 3 attacker och använder laser funktionen - Noel
    {
        Laser();
        randomizer = Random.Range(1, 4); 
        if (randomizer == 1) // ATK1: skapar en macka slumpat y-värde - Noel
        {
            Instantiate(macka, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);
        }
        else if (randomizer == 2) // ATK2: skapar en låda över spelaren - Noel
        {
            player = GameObject.Find("Player");
            Instantiate(box, player.transform.position + new Vector3(0, 10, 0), transform.rotation);
            
        }
        else if (randomizer == 3) // ATK3: skapar 3 lådar vid slumpat y-värde - Noel
        { 
            for (int i = 0; i < 3; i++)
            {
                Instantiate(box, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);
                
            }


        }

    }
    private void Laser() //bildar laser vid typ bossens ögon - Noel
    {
        Instantiate(laser, boss.transform.position + new Vector3(0, 2.2f, 0), transform.rotation);
    }




}
