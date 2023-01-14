using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    SpriteRenderer sprite;
    Collider2D collide;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collide = GetComponent<Collider2D>();
        collide.enabled = false;
        sprite.color = Color.red;
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
        if (collision.gameObject.tag == "Player" && gameObject.tag == "Inactive")
        {
            sprite.color = Color.green;
            gameObject.tag = "Active";
        }
        else
        {
            sprite.color = Color.red;
            gameObject.tag = "Inactive";
        }
    }
}
