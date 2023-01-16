using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlattforms : MonoBehaviour
{
    
    PlatformEffector2D effect;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        effect = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.S)) 
        {            
            if (timer <= 0)
            {
                effect.rotationalOffset = 180;
                timer = 1;
            }
            else
            {
                timer -= Time.deltaTime;
                
            }
            
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            timer = 1;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            effect.rotationalOffset = 0;
        }
        */
        if (Input.GetKey(KeyCode.S))
        {
            effect.rotationalOffset = 180;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            effect.rotationalOffset = 0;
        }
        if (effect.rotationalOffset == 180)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                effect.rotationalOffset = 0;
                timer = 0;
            }

        }
    }
}
