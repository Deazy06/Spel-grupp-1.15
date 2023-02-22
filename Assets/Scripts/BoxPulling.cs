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
        xPos = transform.position.x; //förflytta sig på x- alex
    }

    // Update is called once per frame
    void Update()
    {
        if (beingPushed == false) //om lådan inte blir knuffad- alex
        {
            transform.position = new Vector3(xPos, transform.position.y); //förflyttas inte- alex
        }
        else
        {
            xPos = transform.position.x; //om inte (alltså blir knuffad), förflyttas på x- alex
        }

    }
}
