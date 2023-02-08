using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullSceneToggle : MonoBehaviour
{
    public void Fullscene()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;

        Debug.Log("fullscreen is " + Screen.fullScreen);
    }
}
