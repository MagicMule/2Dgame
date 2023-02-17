using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; 

    public static AudioManager instance;
    public AudioMixerGroup audioMixer;
    [SerializeField] AudioMixer mixer;

    public const string MUSIC_KEY = "MusicVolume";
    public const string SFX_KEY = "SFXVolume";


    void Awake ()
    {
        // if there are no instances of this compnent, AudioManger, in the scean it will instanceiate it
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject); // Objekts with this script, AudioManager, persist in screen change
        /* 
         * ".source" refrenses to the audiosorce, the "foreach" takes the Sound Class and fills it with needed variabelse
         * that is; creating a AudioSorce component and assignsing its values.
         */
        foreach (Sound s in sounds) // for all sound in the public "sounds" list
        {
            s.source = gameObject.AddComponent<AudioSource>(); // adds a AuidoSorce component to this gamobjekt, AudioManager
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.source.outputAudioMixerGroup = audioMixer;  //Gives the sound a aduioMixer, where the sound efekts are(?),

        }
        LoadVolume(); //Set the volume
    }

    // Start playing the "Theme" sound 
    void Start ()
    {
        Play("Theme");
    }

    // The "Play" funkton playes audio based on a string given
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        // If s can not be found, return errormasage of the serched name
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play(); //not to be confused by this funktion, playes the Aoudio of the AoudioSorce of the given name (string)
    }

    void LoadVolume() //Volume saved in VolumeSettings.cs
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 1f);

        mixer.SetFloat(VolumeSettings.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20);
        mixer.SetFloat(VolumeSettings.MIXER_SFX, Mathf.Log10(sfxVolume) * 20);
    }
}
