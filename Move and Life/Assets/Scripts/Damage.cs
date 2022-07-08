using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (AudioSource))]
public class Damage : MonoBehaviour
{
    public AudioClip _damageAudio;
    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            collider.GetComponent<Health>()._health -= 25;
            _source.PlayOneShot(_damageAudio);
        }
    }
}
