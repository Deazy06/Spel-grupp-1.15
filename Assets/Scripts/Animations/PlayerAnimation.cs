using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator animation;

    public void Jumping()
    {
        animation.SetTrigger("Jumping");
    }
    public void WalkingAnim()
    {
        animation.SetTrigger("Walking");
    }

}
