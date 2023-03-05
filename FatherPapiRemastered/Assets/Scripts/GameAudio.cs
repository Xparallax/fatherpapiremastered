using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    public AudioClip godMode;

    public void SwitchToGodMode()
    {
        audioSource.Stop();
        audioSource.clip = godMode;
        audioSource.Play();
    }

    public void SwitchToNormal()
    {
        audioSource.Stop();
        audioSource.clip = backgroundMusic;
        audioSource.Play();
        }
}
