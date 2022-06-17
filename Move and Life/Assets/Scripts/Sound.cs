using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
   [SerializeField] private AudioSource _audioSource;

    public AudioClip _runForest;
    public AudioClip _afterRun;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void StepSound()
    {
        _audioSource.PlayOneShot(_runForest);
    }

    public void AfterRun()
    {
        _audioSource.PlayOneShot(_afterRun);
    }
}
