using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    public bool rightmove = true;
    private Animator animation;
    private SpriteRenderer sr;
    private bool canMove = true; 
    private bool isIdling = false; 

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(WaitRandom());
    }

    // Update is called once per frame
    void Update() // Enemy movement Leon
    {
        if (canMove && !isIdling) // check if enemy can move and if IdleAnim is not running
        {
            if (rightmove == true) // Fienden går höger tills den går in i ett object, då vänds kaaraktären plus att den går vänster
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

    // Randomzier och Animations Diyor
    IEnumerator IdleAnim() // Random idle anim 1.5f seconds
    {
        isIdling = true; 
        canMove = false; 
        animation.SetBool("Idle", true);
        yield return new WaitForSeconds(1.5f);
        animation.SetBool("Idle", false);
        canMove = true; 
        isIdling = false; 
    }
    IEnumerator WaitRandom() // randomizer
    {
        float waitTime = Random.Range(2.8f, 4.8f); //range
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Coroutine finished after waiting for " + waitTime + " seconds.");
        StartCoroutine(IdleAnim());
        yield return new WaitForSeconds(2f); // wait 2 seconds before starting WaitRandom again
        StartCoroutine(WaitRandom());
    }
}
