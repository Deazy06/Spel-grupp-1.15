using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSetActive : MonoBehaviour
{
    public void OpenOptions()
    {
        gameObject.SetActive(true);
    }
    public void CloseOptions()
    {
        gameObject.SetActive(false);
    }
}
