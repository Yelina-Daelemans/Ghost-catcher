using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject deathScreen;
    private void Awake()
    {
        if(LevelManager.instance == null) {  instance = this; }
        else { Destroy(gameObject); }
    }
    public void GameOver()
    {
        deathScreen.SetActive(true);
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Main-Menu");
            
    }
}
