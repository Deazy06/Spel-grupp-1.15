using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] GameObject chooseTrigger;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.F))
       {
            door.OpenDoor();
       }
       if (chooseTrigger.tag == "Active")
       {
            door.OpenDoor();
       }
    }
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        chooseTrigger.tag = "Inactive";
        door.CloseDoor();
        
    }
}
