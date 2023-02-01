using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullController : MonoBehaviour
{
    public Animator animation;
    public PlayerPushing playerScript;
    void Start()
    {
        //animation = GetComponent<Animator>();
        playerScript = GetComponent<PlayerPushing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && playerScript.isPushing == true)
        {
            animation.SetBool("F", true);
        }
        else
        {
            animation.SetBool("F", false);
        }
    }
}
