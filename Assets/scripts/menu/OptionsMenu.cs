using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public bool pause = true;
    //public byte gameMode;

    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // if (button 2 players == clicked) 
    //{
        //gameMode == 1;
    //} voor allemaal

}