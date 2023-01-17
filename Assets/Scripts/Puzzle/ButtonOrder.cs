using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOrder : MonoBehaviour
{
    [SerializeField] GameObject trigger1;
    [SerializeField] GameObject trigger2;
    [SerializeField] GameObject trigger3;
    [SerializeField] GameObject trigger4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (trigger1.tag == "Active")
        {
            if (trigger2.tag == "Active")
            {
                if (trigger3.tag == "Active")
                {
                    if (trigger4.tag == "Active")
                    {
                       
                    }
                }
                else if (trigger4.tag == "Active")
                {
                    Inactivate();
                }
            }
            else if (trigger3.tag == "Active" || trigger4.tag == "Active")
            {
                Inactivate();
            }
        }
        else if(trigger2.tag == "Active" || trigger3.tag == "Active" || trigger4.tag == "Active")
        {
             Inactivate();
        }
    }


    private void Inactivate()
    {
        trigger1.tag = "Inactive";
        trigger2.tag = "Inactive";
        trigger3.tag = "Inactive";
        trigger4.tag = "Inactive";
    }
}
