using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    private Animator animation;

    public void Start()
    {
        animation = GetComponent<Animator>();
    }

    //public AudioSource door;
    public void OpenDoor()
    {
        GetComponent<Collider2D>().enabled = false;
        animation.SetTrigger("DoorOpen");
        //gameObject.SetActive(false);
        //door.Play();
    }


    public void CloseDoor()
    {
        GetComponent<Collider2D>().enabled = true;

        if (GetComponent<Collider2D>().enabled == false)
        {
            animation.SetTrigger("DoorClose");

        }
        //gameObject.SetActive(true);
    }
}
    
   
    
