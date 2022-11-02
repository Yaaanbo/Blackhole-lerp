using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public static audio singleton;

    AudioSource audioSource;
    public AudioClip[] clip;

    private void Awake()
    {
        singleton = this;
        audioSource = GetComponent<AudioSource>();
    }
    public void playAudio(int clipIndex)
    {
        audioSource.PlayOneShot(clip[clipIndex]);
    }
}
