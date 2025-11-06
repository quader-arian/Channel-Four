using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] voiceClips;

    private void OnEnable()
    {
        NumberController.OnNumberCorrect += PlayCorrectClip;
    }
    private void OnDisable()
    {
        NumberController.OnNumberCorrect -= PlayCorrectClip;
    }


    private void PlayCorrectClip()
    {
        int temp = Random.Range(0, voiceClips.Length-1);
        audioSource.clip = voiceClips[temp];
        audioSource.Play();
    }
}