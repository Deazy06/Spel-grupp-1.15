using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    bool jump = true;
    [SerializeField] bool climb = false;
    [SerializeField] float playerSpeed = 800;
    [SerializeField] float playerJump = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jump == true)
        {
            rb2d.AddForce(Vector3.up * playerJump);
            jump = false;
        }
        
        if (climb == true && Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0.001f, 0);
            rb2d.AddForce(Vector3.up * playerJump * 0.008f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Slope")
        {
            
        }
        else
        {
            jump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Climb")
        {
            climb = true;
        }
        else
        {
            climb = false;
        }

    }

    public void PlayerDeath()
    {
        
    }
}
