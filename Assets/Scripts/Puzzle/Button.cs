using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool playerTrigger = false;
    bool objTrigger = false;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] private DoorSetActive door;


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

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Inactive")) //Om ett objekt med tagen "player" nuddar ett objekt med tagen "inactive" s� blir triggern p� playern aktiv- Alex
        {
            print("ACtive");
            playerTrigger = true;

        }
        if (collision.gameObject.CompareTag("Box") && gameObject.CompareTag("Inactive")) //Om samma sak h�nder h�r s� blir �ven objektets trigger aktiv- Alex
        {
            print("ACtive");
            objTrigger = true;
        }


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //Om ett objekt nuddar ett annat objekt med tagen "player" s� �r triggern p� playern inaktiv- Alex
        {
            playerTrigger = false;


        }
        if (collision.gameObject.CompareTag("Box")) //Om ett objekt nuddar ett annat objekt med tagen "box" s� �r triggern p� objektet inaktiv- Alex
        {
            objTrigger = false;
        }
    }



}
