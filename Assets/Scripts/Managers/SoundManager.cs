using System;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;
    public static SoundManager Instance => _instance;

    [SerializeField] private AudioSource _soundeffectsource;
    [SerializeField] private AudioSource _backgroundmusicsource;
    [SerializeField] private List<SoundType> sounds;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [Serializable]
    public class SoundType
    {
        public Sounds soundType;
        public AudioClip soundClip;
    }

    public enum Sounds
    {
        background,
        death,
        win,
        point,
        shield,
        worm,
        banana,
        pause,
        button,

    }

    private void Start()
    {
        PlayBackgroudnMusic(Sounds.background);
    }

    public void PlayBackgroudnMusic(Sounds sound)
    {
        AudioClip clip = GetSoundClip(sound);
        if (clip != null)
        {
            _backgroundmusicsource.clip = clip;
            _backgroundmusicsource.Play();

        }
        else
        {
            Debug.Log("No sound");
        }
    }
    public void PlaySoundEfffect(Sounds sound)
    {
        AudioClip clip= GetSoundClip(sound);
        if (clip != null)
        {
            _soundeffectsource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("No sound");
        }
        
    }


    private AudioClip GetSoundClip(Sounds sound)
        {
            SoundType item = sounds.Find(i => i.soundType == sound);
            return item?.soundClip;
        }
    

    public void StopBakcgroundMusic()
    {
        _backgroundmusicsource.Stop();
    }
}

