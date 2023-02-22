using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStayActive : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    { //knappen lyser när den är aktiv, annars inte -Noel
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
    { // Vid kollision med spelaren så blir knappen aktiv -Noel
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Active";
        }
    }
}
