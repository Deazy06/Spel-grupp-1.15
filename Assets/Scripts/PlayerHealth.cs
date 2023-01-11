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
        colorchoose.Add(Color.grey);
        colorchoose.Add(Color.red);
        colorchoose.Add(Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {
            print("aj");
            hp -= 1;
            sprite.color = colorchoose[0 + 1];
        }
    }
}
