using UnityEngine;

public class MainMenu : MonoBehaviour
{
    
    public GameObject targetObject;

    public void Fade(MenuManager menuManager)
    {
        targetObject.SetActive(false);
        //targetObject.GetComponent<Renderer>().enabled = false;
    }
    public void FadeIn(MenuManager menuManager)
    {
        targetObject.SetActive(true);
        print("FadeIn Menu");
        //targetObject.GetComponent<Renderer>().enabled = true;
    }

}
