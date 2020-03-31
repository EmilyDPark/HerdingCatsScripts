using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClass : MonoBehaviour
{
    static MusicClass running = null;

    private AudioSource _audiosource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audiosource = GetComponent<AudioSource>();

        if (running == null)
        {
            _audiosource.Play();
            running = this;
        }
        else
        {
            if (_audiosource.isPlaying)
                return;
        }
    }

    public void PlayMusic()
    {
        if (_audiosource.isPlaying) return;
        _audiosource.Play();
    }
    
    public void StopMusic()
    {
        _audiosource.Stop();
    }
}
