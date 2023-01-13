using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 3;
    SpriteRenderer sprite;
    List<Color> colorchoose;
    float regain = 0;
    [SerializeField] float timer = 0;
    int respawnPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        colorchoose = new List<Color>();
        colorchoose.Add(new Color(0, 0, 0, 1));
        colorchoose.Add(new Color(0, 0.5f, 0, 1));
        colorchoose.Add(new Color(0.5f, 1, 0.5f, 1));
        colorchoose.Add(new Color(1,1,1,1));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 3 && hp != 0)
        {
            regain += 0.5f * Time.deltaTime;
            print("regain");
            if (regain >= 1)
            {
                regain = 0;
                hp += 1;
                sprite.color = colorchoose[hp];
            }
        }


        if (hp <= 0)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
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
            hp -= 1;
            sprite.color = colorchoose[hp];
        }
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
            respawnPoint += 1;
        }
    }
    private void PlayerRespawn()
    {
        hp = 3;
        transform.position = new Vector3(0, 0, 0);
        GameObject.Find("CheckPoint" + respawnPoint).GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
        sprite.color = colorchoose[hp];
    }
}
