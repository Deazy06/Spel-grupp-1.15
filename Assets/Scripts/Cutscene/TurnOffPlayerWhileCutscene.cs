using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffPlayerWhileCutscene : MonoBehaviour
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
