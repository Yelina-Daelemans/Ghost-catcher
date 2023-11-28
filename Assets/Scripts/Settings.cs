using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    //public AudioMixer audiomixer;
    Resolution[] resolutions;
    public TMPro.TMP_Dropdown resolutionsDropdown;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionsDropdown.ClearOptions();
        List<string> option  = new List<string>();

        int CurrentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string options = resolutions[i].width + "x" + resolutions[i].height;
            option.Add(options);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentResolutionIndex = i;
            }
        }
        resolutionsDropdown.AddOptions(option);
        resolutionsDropdown.value = CurrentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
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
