using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeValue : MonoBehaviour
{
    public AudioMixerGroup mixer;
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(delegate { ChangeEffectVolume(); });
    }

    public void ChangeEffectVolume()
    {
        mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volumeSlider.value));
    }
}