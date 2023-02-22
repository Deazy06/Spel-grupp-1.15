using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPulling : MonoBehaviour
{

    public bool beingPushed;
    float xPos;

    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x; //f�rflytta sig p� x- alex
    }

    // Update is called once per frame
    void Update()
    {
        if (beingPushed == false) //om l�dan inte blir knuffad- alex
        {
            transform.position = new Vector3(xPos, transform.position.y); //f�rflyttas inte- alex
        }
        else
        {
            xPos = transform.position.x; //om inte (allts� blir knuffad), f�rflyttas p� x- alex
        }

    }
}
