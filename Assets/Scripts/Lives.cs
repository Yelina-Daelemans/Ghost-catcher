using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{
    public int Health;
    public int NumberOfHearts;

    public Image[] hearts;
    public Sprite FullHearts;
    public Sprite EmptyHearts;

    public PlayerHealth playerhealth;

    void Update()
    {
        Health = playerhealth.health; // zorgt er voor dat het de zelfde levens values heeft als de PlayerHealth script
        NumberOfHearts = playerhealth.maxhealth; // zorgt er voor dat het de max aantal leven toont.
        if(Health > NumberOfHearts)
        {
            Health = NumberOfHearts;
        }
        for(int i = 0; i < hearts.Length; i++)
        {
            if(i< Health)
            {
                hearts[i].sprite = FullHearts;

            }
            else
            {
                hearts[i].sprite= EmptyHearts;
            }
            if (i < NumberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
