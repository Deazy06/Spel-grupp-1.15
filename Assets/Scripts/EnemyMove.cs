using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool rightmove = true;
    private Animator animation;
    private SpriteRenderer sr;
    private bool canMove = true; // new variable to control movement
    private bool isIdling = false; // new variable to check if IdleAnim coroutine is running

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(WaitRandom());
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove && !isIdling) // check if enemy can move and if IdleAnim is not running
        {
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

    IEnumerator IdleAnim()
    {
        isIdling = true; // set isIdling to true before starting the coroutine
        canMove = false; // set canMove to false before starting the coroutine
        animation.SetBool("Idle", true);
        yield return new WaitForSeconds(1.5f);
        animation.SetBool("Idle", false);
        canMove = true; // set canMove to true when the coroutine is finished
        isIdling = false; // set isIdling to false when the coroutine is finished
    }
    IEnumerator WaitRandom()
    {
        float waitTime = Random.Range(3f, 5f);
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Coroutine finished after waiting for " + waitTime + " seconds.");
        StartCoroutine(IdleAnim());
        yield return new WaitForSeconds(2f); // wait 2 seconds before WaitRandom 
        StartCoroutine(WaitRandom());
    }
}
