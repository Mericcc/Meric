using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{

    private bool _muteBackgroundMusic = false; // Muziek in de achtergrond
    private bool _muteSoundFx = false; // Sound effect als je op de letters drukt
    public static SoundManager instance;

    private AudioSource _audioSource;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        _audioSource = GetComponent<AudioSource>(); 
        _audioSource.Play();
    }

    public void ToggleBackGroundMusic()
    {
        _muteBackgroundMusic = !_muteBackgroundMusic;
        if(_muteBackgroundMusic)
        {
            _audioSource.Stop();
        }
        else
        {
            _audioSource.Play();
        }
    }

    public void ToggleSoundFX()
    {
        _muteSoundFx = !_muteSoundFx;
        GameEvents.OnToggleSoundFXMethod();
    }

    public bool IsBackgroundMusicMuted()
    {
        return _muteBackgroundMusic;
    }

    public bool IsSoundFXMuted()
    {
        return _muteSoundFx;
    }

    public void SilienceBackGroundMusic(bool silience)
    {
        if(_muteBackgroundMusic == false)
        {
            if(_muteBackgroundMusic == false)
            {
                if (silience)
                    _audioSource.volume = 0f;
                else 
                    _audioSource.volume = 1f;
            }
        }
    }

}
