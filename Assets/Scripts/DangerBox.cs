using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { //Vid kollision ställs tagen till Box -Noel
        if (collision.gameObject.tag == "NoDanger")
        {
            gameObject.tag = "Box";
        }
    }
}

