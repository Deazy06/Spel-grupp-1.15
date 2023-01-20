using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDeath : MonoBehaviour
{
    Collider2D collid;
    bool start = false;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        collid = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Danger")|| collision.gameObject.CompareTag("Pushable"))
        {
            transform.localScale = new Vector3(5, 1, 1);
            collid.enabled = false;
            start = true;
        }

    }
}
