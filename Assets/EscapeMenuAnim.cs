using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenuAnim : MonoBehaviour
{
    private Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();

    }

    public void EscapeFadeOut()
    {
        animation.SetTrigger("EscapeFadeOut");
    }
    
    void Update()
    {
        
    }
}
