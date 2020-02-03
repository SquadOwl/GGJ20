using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource source;

    public void PlayLose()
    {
        source.Play();
    }

    public void ChangeSound(float value)
    {
        source.volume = value;
    }
}
