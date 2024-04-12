using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AttackSoundEvent : MonoBehaviour
{
    AudioSource mySourse;
    public AudioSource myClip;
    public AudioSource myClip2;
    public AudioSource dodgeClip;
    public AudioSource stretClip;
    public AudioSource shotClip;
    // Start is called before the first frame update
    void Start()
    {
        mySourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VoidEventSound()
    {
        myClip.Play();
    }
    public void VoidEventSound2()
    {
        myClip2.Play();
    }
    public void DodgeEventSound()
    {
        dodgeClip.Play();
    }
    public void StretEventSound()
    {
        stretClip.Play();
    }
    public void ShotEventSound()
    {
        shotClip.Play();
    }
}