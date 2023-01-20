using UnityEngine;

public class DoorOpenAlt : MonoBehaviour
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
            animation.SetTrigger("DoorClose");        
        //gameObject.SetActive(true);
    }
}



