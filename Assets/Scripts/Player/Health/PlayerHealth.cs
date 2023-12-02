using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health; // is gonna keep track of the players health in general
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
        // Dit zorgt er voor dat als de player dood is dat die niet meer kan bewegen.
        health -= amount;
        if(health <= 0)
        {
            playerRender.enabled = false;
            movement.enabled = false;
            //GameOver() zorgt er voor dat je een game over scherm krijgt te zien.
            LevelManager.instance.GameOver();
        }
    }
    public void AddHealth(int value)
    {
        health = Mathf.Clamp(health + value, 0, maxhealth); 
    }
}
