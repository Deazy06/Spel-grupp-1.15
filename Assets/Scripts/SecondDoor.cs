using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    [SerializeField] DoorSetActive door;
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        door.CloseDoor();

    }
}
