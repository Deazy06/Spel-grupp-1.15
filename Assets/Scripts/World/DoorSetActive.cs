using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    public int open;
    private Animator animation;

    public void Start()
    {
        animation = GetComponent<Animator>();
    }

    //public AudioSource door;
    public void OpenDoor()
    {
        if (open == 1)
        {
            GetComponent<Collider2D>().enabled = false;
        }
        if (open == 3)
        {
            open = 2;
        }
        open += 1;
        animation.SetTrigger("DoorOpen");
        //gameObject.SetActive(false);
        //door.Play();
    }


    public void CloseDoor()
    {
        GetComponent<Collider2D>().enabled = true;
        animation.SetTrigger("DoorClose");
        //gameObject.SetActive(true);
    }
}



