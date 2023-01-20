using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    public int open;
    public int close;
    private Animator animation;

    public void Start()
    {
        animation = GetComponent<Animator>();
    }

    //public AudioSource door;
    public void OpenDoor()
    {
        print("open");
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
        if (close == 1)
        {
            GetComponent<Collider2D>().enabled = true;
        }
        if (close == 3)
        {
            close = 2;
        }
        close += 1;
        animation.SetTrigger("DoorClose");
        //gameObject.SetActive(true);
    }
}



