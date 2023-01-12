using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public Rigidbody2D rb2d;
    bool jump = true;
    bool climb = false;
    [SerializeField] float playerSpeed = 500;
    [SerializeField] float playerJump = 500;
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

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Slope")
        {
            rb2d.AddForce(Vector3.up * playerJump * 0.0016f);
        }
        else
        {
            jump = true;
            climb = false;
        }
    }
}
