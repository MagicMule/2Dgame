using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider; // The Music Slider in canvis, canging the music volume in game
    [SerializeField] Slider sfxSlider;  // The sound efekt slider caangine the sdx volume in game

    public const string MIXER_MUSIC = "MusicVolume"; // string variable to store Music Volume
    public const string MIXER_SFX = "SFXVolume"; // string variable to store SFX volume

    void Awake()
    {
        //Adds listener, when the value of the slider is canged this exexuton whill happen again, via onValueCanged (?)
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSfxVolume);
    }

    void Start()
    {
        // Gets the valume value the player set last gamesetion, if no valu to be found set to 1
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f); 
        sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFX_KEY, 1f);
    }

    void OnDisable()
    {
        /* 
         * Stores the valume value seting localy, save player preferences between game sessions 
        */
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY,musicSlider.value);
        PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);
    }

    void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);

    }
    void SetSfxVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);

    }
}
