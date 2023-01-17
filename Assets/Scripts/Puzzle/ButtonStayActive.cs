using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStayActive : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Active")
        {
            sprite.color = Color.white;
        }
        else
        {
            sprite.color = Color.grey;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Active";
            sprite.color = Color.white;
        }
        
        
       


    }
}
