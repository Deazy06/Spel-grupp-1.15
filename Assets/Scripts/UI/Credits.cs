using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject targetObject;
    private Animator animation;
    void Start()
    {
        animation = GetComponent<Animator>();
    }


    public void CreditFadeIn(MenuManager menuManager)
    {
        targetObject.GetComponent<RectTransform>().localPosition = Vector3.zero;

        animation.SetTrigger("CreditFadeIn");
    }
    public void CreditFadeOut(MenuManager menuManager)
    {
        // targetObject.GetComponent<RectTransform>().localPosition = targetPosition;

        animation.SetTrigger("CreditFadeOut");
    }
}
