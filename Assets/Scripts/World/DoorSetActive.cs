using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    private Animator animation;
    //private SpriteRenderer sprite;

    public void Start()
    {
        //sprite = GetComponent<SpriteRenderer>();
        //animation = GetComponent<Animator>();
    }

    //public AudioSource door;
    public void OpenDoor()
    {
<<<<<<< Updated upstream

=======
        //GetComponent<Collider2D>().enabled = false;
        //animation.SetTrigger("DoorOpen");
        //sprite.color = new Color(0, 0, 0, 0);
        
>>>>>>> Stashed changes
        gameObject.SetActive(false);
        //door.Play();
    }


    public void CloseDoor()
    {
<<<<<<< Updated upstream

        gameObject.SetActive(true);
=======
        gameObject.SetActive(true);
        GetComponent<Collider2D>().enabled = true;

        if (GetComponent<Collider2D>().enabled == false)
        {
            //animation.SetTrigger("DoorClose");
            //sprite.color = new Color(1, 1, 1, 1);


        }
        
>>>>>>> Stashed changes
    }
}
    
   
    
