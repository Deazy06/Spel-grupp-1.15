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

        if (Input.GetKeyDown(KeyCode.L))
        {
            Randomize();
        }
        if (start == true)
        {
            timer += 1 * Time.deltaTime;
            if (timer >= 3)
            {
                timer = 0;
                Randomize();
            }
            timer1 += Time.deltaTime;
            if (timer1 >= 2)
            {
                timer1 = 0;
                deathTimer += 1;
                if (deathTimer == 20)
                {
                    
                    Instantiate(box, location.transform.position + new Vector3(3.5f, 0, 0), transform.rotation);
                }
                else if (deathTimer == 21)
                {
                    Destroy(boss);
                    timer = 0;
                    deathTimer = 0;
                    bossaudio.Stop();
                    start = false;
                    
                }



            }
        }

        deathCheck = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        if (deathCheck.color == new Color(0, 0, 0, 0))
        {

            start = false;
            timer = 0;
            deathTimer = 0;
            collide.enabled = true;
            bossaudio.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collide.enabled = false;
            start = true;
            bossaudio.Play();
            Randomize();
        }
        

    }  
    private void Restart()
    {
        start = false;
        start = true;
    }
    private void BossDeath()
    {
        Instantiate(box, location.transform.position + new Vector3(2, 0, 0), transform.rotation);
    }
    private void Randomize()
    {
        randomizer = Random.Range(1, 4);
        if (randomizer == 1)
        {
            print("1");
            Instantiate(macka, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);

        }
        else if (randomizer == 2)
        {
            print("2");
            player = GameObject.Find("Player");
            Instantiate(box, player.transform.position + new Vector3(0,10,0), transform.rotation);
        }
        else if (randomizer == 3)
        {
            print("3");
            for (int i = 0; i < 3; i++)
            {
                Instantiate(box, location.transform.position + new Vector3(Random.Range(0, -11), 0, 0), transform.rotation);
            }
            
        }
    }
}
