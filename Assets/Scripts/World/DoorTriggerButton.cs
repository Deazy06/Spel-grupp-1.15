using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] private DoorSetActive door2;

    bool active1;
    bool active2;
    bool active3;

    [SerializeField] Color chooseColor1;
    [SerializeField] Color chooseColor2;
    [SerializeField] Color chooseColor3;
    [SerializeField] SpriteRenderer chooseSprite1;
    [SerializeField] SpriteRenderer chooseSprite2;
    [SerializeField] SpriteRenderer chooseSprite3;
    [SerializeField] GameObject chooseTrigger1;
    [SerializeField] GameObject chooseTrigger2;
    [SerializeField] GameObject chooseTrigger3;
    private void Start()
    {

    }

    private void Update()
    {
        
        
        if (chooseSprite1.color == new Color(0, 0, 0, 0)) 
        {
            if (chooseTrigger1.tag == "Active")
            {
                active1 = true;
            }
            else
            {
                active1 = false;
            }
        }
        else
        {
            if (chooseSprite1.color == chooseColor1)
            {
                active1 = true;
            }
            else
            {
                active1 = false;
            }
        }

        if (chooseSprite2.color == new Color(0, 0, 0, 0))
        {
            if (chooseTrigger2.tag == "Active")
            {
                active2 = true;
            }
            else
            {
                active2 = false;
            }
        }
        else
        {
            if (chooseSprite2.color == chooseColor2)
            {
                active2 = true;
            }
            else
            {
                active2 = false;
            }
        }

        if (chooseSprite3.color == new Color(0, 0, 0, 0))
        {
            if (chooseTrigger3.tag == "Active")
            {
                active3 = true;
            }
            else
            {
                active3 = false;
            }
        }
        else
        {
            if (chooseSprite3.color == chooseColor3)
            {
                active3 = true;
            }
            else
            {
                active3 = false;
            }
        }


        if (active1 == true && active2 == true && active3 == true)
        {
            door.OpenDoor();
        }
        else
        {
            door.CloseDoor(); 
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active1 = false;
            door.CloseDoor();
        }
    }
}
