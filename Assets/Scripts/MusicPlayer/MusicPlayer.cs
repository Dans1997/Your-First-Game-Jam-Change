﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] AudioClip levelMusic;
    [SerializeField] AudioClip loseMusic;
    [SerializeField] AudioClip winMusic;

    // Cached Components
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ChangeMusic(levelMusic);
    }

    public void ChangeToLoseMusic()
    {
        audioSource.loop = false;
        ChangeMusic(loseMusic);
    }

    public void ChangeToWinMusic()
    {
        audioSource.loop = false;
        ChangeMusic(winMusic);
    }

    private void ChangeMusic(AudioClip newClip)
    {
        if (audioSource.isPlaying) audioSource.Stop();
        audioSource.clip = newClip;
        audioSource.Play();
    }
}
