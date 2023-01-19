using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    public AudioSource door;
    public void OpenDoor()
    {
        gameObject.SetActive(false);


        door.Play();
    }


    public void CloseDoor()
    {
        gameObject.SetActive(true);

    }
}
    
   
    
