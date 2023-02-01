using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPlayerWhileCutscene : MonoBehaviour // Som den heter. Stänger av players movement script när cutscene scenen startar är igång.
{
    
    void Start()
    {
        if (GameObject.Find("Player") != null)
        {
            GameObject.Find("Player").GetComponent<NewPlayerMovement>().enabled = false;
        }
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    {
        if (GameObject.Find("Player") != null)
        {
            GameObject.Find("Player").GetComponent<NewPlayerMovement>().enabled = true;
        }
    }
}
