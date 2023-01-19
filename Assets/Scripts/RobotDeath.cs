using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDeath : MonoBehaviour
{
    Collider2D collid;
    // Start is called before the first frame update
    void Start()
    {
        collid = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            transform.localScale = new Vector3(5, 1, 1);
            collid.enabled = false;
        }

    }
}
