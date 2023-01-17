using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System;
using UnityEngine.Events;
using System.Collections.Concurrent;

public class AudioSettings : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 0.75f;

    public Settings settings;

    private void Start()
    {
        //Debug.Log("playerPrefsEvent_VolumeChange initialized");
        if (settings != null)
        {
            SetVolume(settings.LoadVolumeFromPlayerPrefs());
        }
        //playerPrefsEvent_VolumeChange = ;
    }

    public void SetVolume(float volume)
    {
        volumeSlider.value = volume;
        volumeTextValue.text = Mathf.CeilToInt(volume * 100).ToString();

        AudioListener.volume = volume;

        //settings.UpdateGlobalVolume(volume);

        PlayerPrefs.SetFloat("mastervolume", volume);
    }


    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            SetVolume(defaultVolume);
        }
    }
    public IEnumerator ConfirmationBox()
    {
        yield return new WaitForSeconds(2);
        /*confirmationPrompt.SetActive(true);
        
        confirmationPrompt.SetActive(false);*/
    }

}
