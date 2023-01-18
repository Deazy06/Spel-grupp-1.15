using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool playerTrigger = false;
    bool objTrigger = false;
    [SerializeField] SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTrigger == true|| objTrigger == true)
        {
            gameObject.tag = "Active";
            sprite.color = Color.white;
        }
        else
        {
            gameObject.tag = "Inactive";
            sprite.color = Color.grey;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Inactive"))
        {
            print("ACtive");
            playerTrigger = true;
        }
        if (collision.gameObject.CompareTag("Box") && gameObject.CompareTag("Inactive"))
        {
            print("ACtive");
            objTrigger = true;
        }


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTrigger = false;
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            objTrigger = false;
        }
    }



}
