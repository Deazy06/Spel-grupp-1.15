using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float speed = 2f;
    public bool rightmove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        print("noelfat");
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
