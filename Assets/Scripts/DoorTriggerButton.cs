using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] GameObject chooseTrigger1;
    [SerializeField] GameObject chooseTrigger2;
    [SerializeField] GameObject chooseTrigger3;

    private void Start()
    {
        
        
    }

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.F))
       {
            door.OpenDoor();
       }
       if (chooseTrigger1.tag == "Active"&& chooseTrigger2.tag == "Active"&& chooseTrigger3.tag == "Active")
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
