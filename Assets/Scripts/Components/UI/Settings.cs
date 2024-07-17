using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Settings : MonoBehaviour
{
    [SerializeField] private Button exitButton;
    [SerializeField] private Slider soundSlider;
    [SerializeField] private Slider musicSlider;
    
    private const string SoundPrefKey = "SoundVolume";
    private const string MusicPrefKey = "MusicVolume";

    void Start()
    {
        LoadSettings();

        exitButton.onClick.AddListener(ExitToMainMenu);

        soundSlider.onValueChanged.AddListener(OnSoundSliderValueChanged);
        musicSlider.onValueChanged.AddListener(OnMusicSliderValueChanged);
    }
    
    private void LoadSettings()
    {
        if (PlayerPrefs.HasKey(SoundPrefKey))
        {
            soundSlider.value = PlayerPrefs.GetFloat(SoundPrefKey);
        }

        if (PlayerPrefs.HasKey(MusicPrefKey))
        {
            musicSlider.value = PlayerPrefs.GetFloat(MusicPrefKey);
        }
    }
    private void SaveSettings()
    {
        PlayerPrefs.SetFloat(SoundPrefKey, soundSlider.value);
        PlayerPrefs.SetFloat(MusicPrefKey, musicSlider.value);
        PlayerPrefs.Save();
    }
    private void ExitToMainMenu()
    {
        
        SaveSettings();
        string mainMenuSceneName = "MainMenu";
        SceneManager.LoadScene(mainMenuSceneName);
    }

    private void OnSoundSliderValueChanged(float value)
    {
       // Debug.Log("Sound Slider Value: " + value);
        
        SaveSettings();

    }

    private void OnMusicSliderValueChanged(float value)
    {
       // Debug.Log("Music Slider Value: " + value);
        
        SaveSettings();
    }
}
