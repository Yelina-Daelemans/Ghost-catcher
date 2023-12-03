using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        // zorgt er voor dat als je naar level 1 terug gaat de muziek terug hoort
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            AudioManager.instance.GetComponent<AudioSource>().Play();

        }
    }

    // Update is called once per frame
    void Update()
    {
        // zorgt er voor dat als je naar de main menu gaat dat je geen twee muziekjes hoort maar maar 1 in de plaats
        if (SceneManager.GetActiveScene().name == "Main-Menu")
        {
            AudioManager.instance.GetComponent<AudioSource>().Pause();
            
        }
    }
}
