using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(true);
        }
    }
    public void ResumeGame()
    {
        gameObject.SetActive(false);
    }
}
   
