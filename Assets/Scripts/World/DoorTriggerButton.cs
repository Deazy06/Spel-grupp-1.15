using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] private DoorSetActive door2;

    [SerializeField] bool colorUse1 = true;
    [SerializeField] bool colorUse2 = true;
    [SerializeField] bool colorUse3 = true;

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
        if (chooseSprite1 == null)
        {
            bool colorUse1 = false;
        }
        if (chooseSprite2 == null)
        {
            bool colorUse2 = false;
        }
        if (chooseSprite3 == null)
        {
            bool colorUse3 = false;
        }

    }

    private void Update()
    {
        
        if (colorUse1 == true)
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
        else if (colorUse1 == false)
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

        if (colorUse2 == true)
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
        else if (colorUse2 == false)
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

        if (colorUse3 == true)
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
        else if (colorUse3 == false)
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

        if (active1 == true && active2 == true && active3 == true) 
        {
            door.OpenDoor();
            door2.OpenDoor();
        }
        else
        {
            door.CloseDoor();
            door2.CloseDoor();
        }
        /*

        if (colorUse2 == true)
        {
            if (chooseSprite2.color == chooseColor2)
            {
                active2 = true;
            }
        }
        if (colorUse3 == true)
        {
            if (chooseSprite3.color == chooseColor3)
            {
                active3 = true;
            }
        }
        /*
        if (chooseSprite1.color == chooseColor1)
        {
            chooseTrigger1.tag = "Active";
        }
        if (chooseSprite2.color == chooseColor2)
        {
            chooseTrigger2.tag = "Active";
        }
        if (chooseSprite3.color == chooseColor3)
        {
            chooseTrigger3.tag = "Active";
        }
        if (chooseTrigger1.tag == "Active" && chooseTrigger2.tag == "Active" && chooseTrigger3.tag == "Active")
        {
            door.OpenDoor();
        }
        else
        {
            door.CloseDoor();
        }
        

        if (Input.GetKeyDown(KeyCode.F))
       {
            door.OpenDoor();
       }
        
        if (colorUse == false)
        {
            if (chooseTrigger1.tag == "Active" && chooseTrigger2.tag == "Active" && chooseTrigger3.tag == "Active")
            {
                door.OpenDoor();
            }
            else
            {
                door.CloseDoor();
            }
        }
        else
        {
            if (chooseSprite1.color == chooseColor1 && chooseSprite2.color == chooseColor2 && chooseSprite3.color == chooseColor3)
            {
                door.OpenDoor();
            }
            else
            {
                door.CloseDoor();
            }
        }
        */
        
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
