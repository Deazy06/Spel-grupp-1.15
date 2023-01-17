using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullSceneToggle : MonoBehaviour
{
    public void Fullscene(bool is_fullscene)
    {
        Screen.fullScreen = is_fullscene;

        Debug.Log("fullscreen is " + is_fullscene);
    }
}
