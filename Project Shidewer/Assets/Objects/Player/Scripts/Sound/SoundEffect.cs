using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource soundPlay;
    public AudioSource soundPlay2;
    public AudioSource soundPlay3;
    public AudioSource soundPlay4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayThosSoundEffect()
    {
        soundPlay.Play();
    }
    public void PlayThosSoundEffect2()
    {
        soundPlay2.Play();
    }

    public void PlayThosSoundEffect3()
    {
        soundPlay3.Play();
    }

    public void PlayThosSoundEffect4()
    {
        soundPlay4.Play();
    }
}