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

        gameObject.SetActive(false);
        //door.Play();
    }


    public void CloseDoor()
    {

        gameObject.SetActive(true);
    }
}
    
   
    
