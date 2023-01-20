using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    public bool trigger;
    [SerializeField] DoorSetActive door;

    public void Update()
    {
        if (trigger == true)
        {
            FindObjectOfType<DoorSetActive>().CloseDoor();
            trigger = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision2d)
    {
        trigger = true;
        
        
        
    }

}
