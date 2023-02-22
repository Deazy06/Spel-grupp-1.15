using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 3;
    SpriteRenderer sprite;
    List<Color> colorchoose;
    float regain = 0;
    Vector3 respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;

        sprite = GetComponent<SpriteRenderer>();
        colorchoose = new List<Color>();
        colorchoose.Add(new Color(0, 0, 0, 1));
        colorchoose.Add(new Color(0, 0.5f, 0, 1));
        colorchoose.Add(new Color(0.5f, 1, 0.5f, 1));
        colorchoose.Add(new Color(1,1,1,1));
        
    }

    //Jag skrev grunden till koden som nu skrivits om -Alex

    // Update is called once per frame
    void Update()
    {
        if (hp < 3 && hp != 0)
        {
            regain += 0.5f * Time.deltaTime;
            print("regain");
            if (regain >= 2)
            {
                regain = 0;
                hp += 1;
                sprite.color = colorchoose[hp];
            }
        }


        if (hp <= 0)
        {
            GameObject.Find("Player").GetComponent<NewPlayerMovement>().enabled = false;
            if (Input.GetKeyDown(KeyCode.R))
            {
                PlayerRespawn();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            print("aj");
            sprite.color = colorchoose[hp];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            respawnPoint = transform.position;
            print("Set Spawnpoint");
        }
    }
    private void PlayerRespawn()
    {
        hp = 3;
        transform.position = new Vector3(0, 0, 0);
        transform.position = respawnPoint;
        GetComponent<NewPlayerMovement>().enabled = true;
        sprite.color = colorchoose[hp];
    }
}
