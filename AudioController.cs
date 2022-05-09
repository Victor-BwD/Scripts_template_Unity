using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip clip1; // Var to keep your audio clip 1
    public AudioClip clip2; // Var to keep your audio clip 2
    public AudioClip backgroundMusic; // Var to keep your audio background

    public AudioSource audioSource; // Var to keep the audioSource component
    public static AudioController instance; // Actual audio clip

    // Start is called before the first frame update
    void Start()
    {
        instance = this; // Receive this class

        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    // Function to receive a audio and change, use this in other script
    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip); // Play another audio
    }

    // Function to change background music, use this in other script
    public void ChangeBGM()
    {
        audioSource.clip = backgroundMusic;
    }
}
