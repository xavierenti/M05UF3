using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource;
    public AudioSource[] sfxsSource;
    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //Per a ficar la canso k vulgueu al comensar
        //PlayMusic ("El nom de la canso");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Musica no trobada");
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

        if (s == null)
        {
            Debug.Log("sonido no trobada");
        }
        else
        {
            for (int i = 0; i < sfxsSource.Length; i++)
            {
                sfxsSource[i].PlayOneShot(s.clip);
            }
        }
    }

    //Botons i sorolls

    public void ButtonMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ButtonSFX()
    {
        for (int i = 0; i < sfxsSource.Length; i++)
        {
            sfxsSource[i].mute = !sfxsSource[i].mute;
        }

    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        for (int i = 0; i < sfxsSource.Length; i++)
        {
            sfxsSource[i].volume = volume;
        }

    }
}
