using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] bool colorUse = true;
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
       if (Input.GetKeyDown(KeyCode.F))
       {
            door.OpenDoor();
       }
       
    }
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        chooseTrigger1.tag = "Inactive";
        door.CloseDoor();
        
    }
}
