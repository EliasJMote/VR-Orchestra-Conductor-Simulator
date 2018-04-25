using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
[System.Serializable]
public class AudioManager : MonoBehaviour {
    public Sound[] sounds;
    public Controller c;
	
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
   
	void Start () {
        if (SceneManager.GetActiveScene().name == "Title Screen")
        {
            Play("Theme");
        }
        else
        {
            Debug.Log("Controller song: " + Controller.song);
            Play(Controller.song);
        }
	}
	
	// Update is called once per frame
	public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    
	}
    public void SetVolume( float v)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Theme");
        if(v > s.volume)
        {
            if(s.volume + v > 1.0)
            {
                s.volume = 1.0F;
            }
            else
            {
                s.volume += v;
            }
        }
        else
        {

        }

        s.volume -= v;
    }
}
