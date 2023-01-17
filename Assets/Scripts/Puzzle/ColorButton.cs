using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    SpriteRenderer sprite;
    List<Color> colorchoose;
    Collider2D collide;
    [SerializeField] int activeColor = 0;
    // Start is called before the first frame update
    void Start()
    {
        collide = GetComponent<Collider2D>();
        collide.enabled = false;
        sprite = GetComponent<SpriteRenderer>();
        colorchoose = new List<Color>();
        colorchoose.Add(Color.blue);
        colorchoose.Add(Color.green);
        colorchoose.Add(Color.red);
        colorchoose.Add(Color.black);

        sprite.color = Color.white;
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            collide.enabled = true;
        }
        else 
        {
            collide.enabled = false;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && activeColor < 2)
        {
            activeColor += 1;
            sprite.color = colorchoose[activeColor];
        }
        else
        {
            activeColor = 0;
            sprite.color = colorchoose[activeColor];
        }
    }
}
