using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;
    public AudioMixer audioMixer;


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
         * that is; creating a AudioSorce component and assignsing its varibals.
         */
        foreach (Sound s in sounds) // for all sound in the public "sounds" list
        {
            s.source = gameObject.AddComponent<AudioSource>(); // adds a AuidoSorce to this gamobjekt, AudioManager
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
           // s.source.outputAudioMixerGroup = s.outputAudioMixerGroup;
        }
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
            
        s.source.Play(); //not to beconfused by this funktion, playes the Aoudio of the AoudioSorce of the given name (string)
    }
}
