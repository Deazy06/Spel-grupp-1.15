using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPushing : MonoBehaviour
{
    private Animator animation;
    public float distance = 1f;
    public LayerMask boxMask;
    public bool isPushing;

    GameObject box;
    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    //Allt nedanför förutom animation är Alexandras kod
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask); // skriver "hit" betydelse. push= lådan förflyttas åt höger, x förändras

        if (hit.collider != null && hit.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.F)) //om man håller in F och nuddar ett objekt med tagen "pushable"
        {
            box = hit.collider.gameObject;
            isPushing = true;
            box.GetComponent<FixedJoint2D>().enabled = true; //spelaren och lådan "sitter fast" i varandra
            box.GetComponent<BoxPulling>().beingPushed = true; //referar till BoxPulling script, det blir true
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>(); //spelaren "sätts ihop" temporärt med rigidbodyn på boxen
        }
        else if (Input.GetKeyUp(KeyCode.F)) //håller in F men nuddar inget
        {
            isPushing = false; //här nuddar man inte objekt med tagen pushable, inget händer, därav false nedanför
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<BoxPulling>().beingPushed = false;
        }
        if (isPushing && Input.GetKeyDown(KeyCode.A) && target.localScale.x == 5.57f)
        {
            animation.SetBool("Pull", true);
        }
        if (isPushing == false || Input.GetKeyUp(KeyCode.A))
        {
            animation.SetBool("Pull", false);
        }

        if (isPushing && Input.GetKeyDown(KeyCode.D) && target.localScale.x == 5.57f)
        {
            animation.SetBool("Push", true);
        }
        if (isPushing == false || Input.GetKeyUp(KeyCode.D))
        {
            animation.SetBool("Push", false);
        }

        if (isPushing && Input.GetKeyDown(KeyCode.D) && target.localScale.x == -5.57f)
        {
            animation.SetBool("Pull", true);
        }
        if (isPushing == false || Input.GetKeyUp(KeyCode.D))
        {
            animation.SetBool("Pull", false);
        }

        if (isPushing && Input.GetKeyDown(KeyCode.A) && target.localScale.x == -5.57f)
        {
            animation.SetBool("Push", true);
        }
        if (isPushing == false || Input.GetKeyUp(KeyCode.A))
        {
            animation.SetBool("Push", false);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow; //gränsen på hur långt ifrån man kan dra lådan är ett sträck man kan se i scene, blir gult

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance); //linjen
    }

}
