using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool rightmove = true;
    private Animator animation;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       // animation.SetFloat("xSpeed", 2);
        if (rightmove == true)
        {
            transform.position += new Vector3(2f, 0, 0) * Time.deltaTime;
            animation.SetFloat("xSpeed", 2);
            sr.flipX = false;
        }
        else
        {
            transform.position += new Vector3(-2f, 0, 0) * Time.deltaTime;
            animation.SetFloat("xSpeed", -2);
            sr.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
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

    IEnumerator IdleAnim()
    {
        yield return new WaitForSeconds(1f);

    }

}
