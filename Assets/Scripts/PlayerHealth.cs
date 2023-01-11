using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 3;
    SpriteRenderer sprite;
    List<Color> colorchoose;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        colorchoose = new List<Color>();
        colorchoose.Add (new Color(1,0,0,0));
        colorchoose.Add (new Color(1,0,0,1));
        colorchoose.Add (new Color(1,0,0,1));
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
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
    }
}
