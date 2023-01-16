using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool Trigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (other.tag == "Player" && other.tag == "Enemy") 

        if (collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Inactive"))
        {
            print("ACtive");
            Trigger = true;
            gameObject.tag = "Active";
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Trigger = false;
        gameObject.tag = "Inactive";
    }

}
