using UnityEngine.Audio;
using UnityEngine;

// The Sound class saves some constans realted to playing sound, name, clip, volume, pitch, loop, surce
[System.Serializable]
public class Sound 
{
    public string name; // name of audioclip to be used

    public AudioClip clip; // audioclip to be used

    [Range(0f, 1f)]
    public float volume; // vloume of audio
    [Range(.1f, 3f)]
    public float pitch; // pitch of audio

    public bool loop; // If the the aoudio is to be looped

    [HideInInspector]
    public AudioSource source; //the AudioSource of the sound to be played, 
}
