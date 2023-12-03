using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    public static bool gameIsPaused = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // zorgt er voor dat de game gepauzeerd kan worden als er op escape is gedrukt.
            if(gameIsPaused )
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        // zorgt er voor dat als het pauze scherm er niet meer staat het spel niet bevroren blijft.
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        gameIsPaused = false;
    }
    void Pause()
    {
        //pauseert de game wanneer dat het pause scherm op het scherm staat
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void LoadMenu()
    {
        //zorgt er voor dat de game niet ob bevriezen blijft staan wanneer dat er op play wordt gedrukt in de main menu
        Time.timeScale = 1f;
        // hiermee kan je naar de main munu gaan als je een bepaalde knop aanklikt.
        SceneManager.LoadScene("Main-menu");
    }
    public void QuitGame()
    {
        // zorgt er voor dat je de game kan verlaten
        Debug.Log("Quit game");
        Application.Quit();
    }
    public void SetVolume(float volume)
    {
        // zorgt er voor dat de audio mixer gelinked kan worden met de background music
        audiomixer.SetFloat("Volume", volume);
    }
}
