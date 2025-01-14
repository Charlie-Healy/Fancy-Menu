using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class MusicVolumeSlider : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource musicSource2;
    public AudioSource sfxSource;

    public Toggle AudioToggle;

    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("music", 1) == 1)
        {
            AudioToggle.isOn = true;
        }
        else
        {
            AudioToggle.isOn = false;
        }
    }

    public void Toggle(bool value)
    {
        musicSource.mute = value;
        sfxSource.mute = value;
        musicSource2.mute = value;
        
        if(value == true)
        {
            PlayerPrefs.SetInt("music", 1);                     
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
        }
    }

}
