using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager Instance;
    public AudioSource audioSource;
    public AudioClip[] sounds;

    private void Awake()
    {
        Instance = this;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void SoundPlay(AudioClip sound)
    {
        if (DataManager.Instance.volume_soundEffect == 1f)
            audioSource.PlayOneShot(sound);
    }
}
