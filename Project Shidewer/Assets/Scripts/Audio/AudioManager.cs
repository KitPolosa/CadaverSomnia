using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private List<AudioSource> allAudioSources = new List<AudioSource>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        foreach (AudioSource source in allAudioSources)
        {
            if (source != null && source.isActiveAndEnabled)
            {
                // Здесь вы можете применить изменения к громкости или другим параметрам аудио
                // В данном случае, мы устанавливаем громкость каждого AudioSource
                source.volume = Mathf.Clamp01(source.volume);
            }
        }
    }

    public void AddAudioSource(AudioSource source)
    {
        if (!allAudioSources.Contains(source))
        {
            allAudioSources.Add(source);
        }
    }

    public void RemoveAudioSource(AudioSource source)
    {
        if (allAudioSources.Contains(source))
        {
            allAudioSources.Remove(source);
        }
    }

    public void SetVolumeByTag(string tag, float volume)
    {
        foreach (AudioSource source in allAudioSources)
        {
            if (source.CompareTag(tag))
            {
                source.volume = Mathf.Clamp01(volume);
            }
        }
    }
}