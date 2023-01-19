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

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false; //problemet kan vara här, ta bort en av dem
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask); // alt 2

        if (hit.collider != null && hit.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.F))
        {
            box = hit.collider.gameObject;
            isPushing = true;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<BoxPulling>().beingPushed = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            isPushing = false;
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
        Gizmos.color = Color.yellow;

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }

}
