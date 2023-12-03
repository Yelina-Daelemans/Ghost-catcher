using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //laad de volgende scene in de index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        //hiermee kan je de game verlaten. en kan je het ook zien in unity dat het werkt met de Debug.log
        Debug.Log("You left the game.");
        Application.Quit();
    }

}
