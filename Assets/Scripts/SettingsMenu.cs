using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer mixer;
    public void SetVolume(float v)
    {
        
        mixer.SetFloat("volume", v);
    }
}
