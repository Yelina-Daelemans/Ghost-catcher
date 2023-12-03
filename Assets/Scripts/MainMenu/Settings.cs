using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audiomixer;
    Resolution[] resolutions;
    public TMPro.TMP_Dropdown resolutionsDropdown;

    void Start()
    {
        //zorgt er voor dat je al de resoluties te zien krijgt
        resolutions = Screen.resolutions;
        //zorgt er voor dat de default opties opgeschoont zijn
        resolutionsDropdown.ClearOptions();
        // maakt een nieuwe lijst van opties aan
        List<string> option  = new List<string>();

        int CurrentResolutionIndex = 0;

        //loopt de resoluties in de array
        for (int i = 0; i < resolutions.Length; i++)
        {
            //laat de resoluties als cijfers zien
            string options = resolutions[i].width + "x" + resolutions[i].height;
            //voegt een element toe aan de option lijst
            option.Add(options);

            //zorgt er voor dat je de resoluties gelijk zijn aan de resoluties die als standaard staan of aan klikt
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                CurrentResolutionIndex = i;
            }
        }
        //voegt de option lijst toe aan de resolutionDropdown
        resolutionsDropdown.AddOptions(option);
        //zorgt er voor dat je de resolutie juist staat aan die met jouw computer
        resolutionsDropdown.value = CurrentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        //zorgt er voor dat de resoluties juist staan met de resolutieIndex
        Resolution resolution = resolutions[resolutionIndex];
        //zorgt er voor dat de resoluties ook i  fullscreenmode juist staan
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume)
    {

        // zorgt er voor dat de audio mixer gelinked kan worden met de background music
        audiomixer.SetFloat("Volume", volume);
    }
    public void Quality(int QualityIndex)
    {
        //hiermee kan je de qualiteit instellen
        QualitySettings.SetQualityLevel(QualityIndex);
    }
    public void FullScreen(bool isFullscreen)
    {
        //Hiermee kan fullscreenmode aan en uit geklikt worden en dan krijg je dat in unity te zien in de console
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
