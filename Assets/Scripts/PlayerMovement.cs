using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    bool jump = true;
    float playerSpeed = 1000;
    float playerJump = 500;
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

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Danger")
        {

        }
        else
        {
            jump = true;
        }
    }

    public void PlayerDeath()
    {
        
    }
}
