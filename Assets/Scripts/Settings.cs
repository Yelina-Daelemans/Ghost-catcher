using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public Dropdown resolutionsdropdown;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionsdropdown.ClearOptions();
        List<string> options = new List<string>();
        for(int i = 0; i < resolutions.Length; i++)
        {
            string options = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
        }
        resolutionsdropdown.AddOptions(resolutions);
    }
    public void SetVolume(float volume)
    {
        Debug.Log(volume);
    }
    public void Quality(int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);
    }
    public void FullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        if (isFullscreen == true)
        {
            Debug.Log("Fullscreen is aan");
        }
        else
        {
            Debug.Log("Fullscreen is uit");
        }
    }
}
