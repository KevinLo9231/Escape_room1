using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;    

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource,sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);//為了讓聲音在下個場景不被銷毀
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("BGM");
    }
    public void PlayMusic(string name)
    {               
        Sound s = Array.Find(musicSounds, x => x.name == name);
        //陣列中尋找名稱與參數 name 相匹配的音樂

        if (s == null)
         {
            Debug.Log("Sound Not Found");
         }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        //陣列中尋找名稱與參數 name 相匹配的音樂

        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
        }

    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

}
