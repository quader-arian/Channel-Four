using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] DialSounds;

    private void OnEnable()
    {
        NumberController.OnNumberPressed += PlayTone;
    }
    private void OnDisable()
    {
        NumberController.OnNumberPressed -= PlayTone;
    }


    private void PlayTone(char number)
    {
        int temp = int.Parse(number.ToString());
        audioSource.clip = DialSounds[temp];
        audioSource.Play();
    }
}