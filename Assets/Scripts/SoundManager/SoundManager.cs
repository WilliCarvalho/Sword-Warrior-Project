using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] enviromentSound;
    [SerializeField] private float soundVolume = 100;

    private static SoundManager instance;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance.gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PlaySoundClip(enviromentSound[0]);
    }

    private void Update()
    {
        audioSource.volume = soundVolume / 100;
    }

    public void PlaySoundClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

}
