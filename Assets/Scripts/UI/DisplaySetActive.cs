using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class DisplaySetActive : MonoBehaviour
{
 public void OpenDisplay()
    {
        gameObject.SetActive(true);
    }
    public void CloseDisplay()
    {
        gameObject.SetActive(false);
    }
}
