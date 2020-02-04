using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : Singleton<SoundManager>
{

    public Sound[] sounds;
    
    protected override void Awake()
    {
        base.Awake();
    

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            if (s.isMusic)
            {
                s.source.volume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
            }
            else
            {
                s.source.volume = PlayerPrefs.GetFloat("SoundsVolume", 1);
            }
        }


        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Play("Intro");
        }
        else
        {
            Play("Soundtrack");
        }
    }


    public void Play(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == name) s.source.Play();
        }

    }

    public void Stop(string name)
    {
        foreach(Sound s in sounds)
        {
            if (s.name == name) s.source.Stop();
        }
    }

    public void ChangeMusicVolume(float value)
    {
        foreach (Sound s in sounds)
        {
            if(s.isMusic)
                s.source.volume = value;
        }
        PlayerPrefs.SetFloat("MusicVolume", value);
    }
    

    public void ChangeSoundsVolume(float value)
    {
        foreach (Sound s in sounds)
        {
            if(!s.isMusic)
                s.source.volume = value;
        }
        PlayerPrefs.SetFloat("SoundsVolume", value);
    }
}
