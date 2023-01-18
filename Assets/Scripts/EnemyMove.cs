using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool rightmove = true;
    private Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animation.SetFloat("xSpeed", rb.velocity.x);
        if (rightmove == true)
        {
            transform.position += new Vector3(2f, 0, 0) * Time.deltaTime;

        }
        else
        {
            transform.position += new Vector3(-2f, 0, 0) * Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rightmove == true)
        {
            rightmove = false;
        }
        else
        {
            rightmove = true;
        }
    }

}
