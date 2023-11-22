using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health; // is gonna keep track of the players health
    public int maxhealth = 3; // keeps track of the current health

    public SpriteRenderer playerRender;
    public Character movement;
    

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth; // als de game start dan start je met all jou levens
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            playerRender.enabled = false;
            movement.enabled = false;
            LevelManager.instance.GameOver();
        }
    }
}
