using UnityEngine;

public class NewPlayerMovement : MonoBehaviour // Diyor och Noel
{
    private Animator animation;

    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 11.5f;
    private bool isFacingRight = true;
    bool climb = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    PlayerPushing pushing;

    private void Start()
    {
        animation = GetComponent<Animator>(); 
        pushing = GetComponent<PlayerPushing>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); // A D movement + anim
        
        animation.SetFloat("xSpeed", Mathf.Abs(horizontal));
        animation.SetFloat("ySpeed", rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) // Jump + anim
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animation.SetTrigger("Jumping");
            animation.SetTrigger("FallingStop");
        }

        /*
        if (Input.GetKeyDown(KeyCode.Space) != IsGrounded())
        {
            animation.SetTrigger("FallingStop");
        } 
        */

        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animation.ResetTrigger("Jumping");
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            //animation.ResetTrigger("NotWalking");
            //animation.SetTrigger("Walking");
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            //animation.ResetTrigger("Walking");
            //animation.SetTrigger("NotWalking");
        }

        Flip(); // fixa ny script för flip för att drag pull gubben ska inte vända sig

        if (climb == true && Input.GetKey(KeyCode.W)) // när spelaren kan klättra och trycker W så flyttas karaktären upp.
        {
            transform.position += new Vector3(0, 5f, 0) * Time.deltaTime;
            rb.AddForce(Vector3.up * 1400 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // vid collision med climb och distansen mellan objektet är mindre än 0,7 så kan spelaren klättra tills spelaren möter en till trigger- Noel
        if (collision.gameObject.tag == "Climb") 
        {
            float distance = Vector3.Distance(transform.position, collision.transform.position);
            if (distance > 0.7f)
            {
                climb = true;
            }
        }
        else
        {
            climb = false;
        }
    }




    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
    }

    private void Flip()
    {
        if ((isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) && pushing.isPushing == false)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}