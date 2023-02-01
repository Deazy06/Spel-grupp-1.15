using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllAnim : MonoBehaviour
{
    private Animator animation;
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animation.SetBool("A", true);
        }
        else
        {
            animation.SetBool("A", false);
        }
    }
}
