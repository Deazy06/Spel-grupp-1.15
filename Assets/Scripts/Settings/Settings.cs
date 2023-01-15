using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public void UpdateGlobalVolume(float volume)
    {
        foreach (GameObject audioSource in GameObject.FindGameObjectsWithTag("AudioSource"))
        {
            if (audioSource.TryGetComponent(out AudioSource a))
            {
                Debug.Log("Setting Volume" + a);
                a.volume = volume;
            }
        }
    }

    public float LoadVolumeFromPlayerPrefs()
    {
        Debug.Log("Loading PlayerPrefs mastervolume: " + PlayerPrefs.GetFloat("mastervolume"));
        return PlayerPrefs.GetFloat("mastervolume");
    }
}
