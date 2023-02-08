using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMainMenu : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject targetObject;
    private Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    
    public void SettingsPressed()
    {
        targetObject.GetComponent<RectTransform>().localPosition = Vector3.zero;
        animation.SetTrigger("SettingsFadeIn");
    }

    public void SettingsBack(MenuManager menuManager)
    {
        StartCoroutine(waiter());
    }
    

    IEnumerator waiter()
    {
        animation.SetTrigger("SettingsFadeOut");
        yield return new WaitForSeconds(1.3f);
        targetObject.GetComponent<RectTransform>().localPosition = targetPosition;

    }


}
