using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour // Diyor. Mest Animations och s� att CreditsMenu flyttar sig till mitten. Det beh�vde jag g�ra f�r att jag inaktivera inte av Credits och ist�llet s�tte dens Alpha till 0.
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
        animation.SetTrigger("CreditFadeOut");
        StartCoroutine(waiter());
    }
    IEnumerator waiter() // S� att animations inte overlap
    {
        
        yield return new WaitForSeconds(1.3f);
        targetObject.GetComponent<RectTransform>().localPosition = targetPosition;

    }
}
