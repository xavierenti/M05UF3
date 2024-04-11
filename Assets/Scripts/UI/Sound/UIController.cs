using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    public void MusicButton()
    {
        AudioManager.Instance.ButtonMusic();
    }

    public void SFXButton()
    {
        AudioManager.Instance.ButtonSFX();
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
}
