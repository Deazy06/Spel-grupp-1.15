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
        sprite = GetComponent<SpriteRenderer>(); //G�r lista av f�rger - Noel 
        colorchoose = new List<Color>();
        colorchoose.Add(Color.blue);
        colorchoose.Add(Color.red);
        colorchoose.Add(Color.yellow);
        colorchoose.Add(Color.green);
        colorchoose.Add(Color.black);

        sprite.color = (Color.blue);
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.F)) // Kan collida med knappen med F nertryckt  - Noel
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
        // vid collision med spelaren kommer n�sta f�rg p� listan (ifall det �r sista f�rg p� listan byts det till f�rsta) - Noel
        if (collision.gameObject.tag == "Player" && activeColor < 3) 
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
