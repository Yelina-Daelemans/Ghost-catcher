using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{
    public int Health;
    public int NumberOfHearts;

    public Image[] hearts;
    public Sprite FullHearts;
    public Sprite EmptyHearts;

    void Update()
    {
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
    public void DoDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}
