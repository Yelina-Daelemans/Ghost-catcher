using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    [SerializeField] private int healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // zorgt er voor dat wanneer dat het object met de speler in aanraking komt dat er levens bij komen
        if(collision.tag == "Player")
        {
            // het gedeelte waardat levens gaan bij komen
            collision.GetComponent<PlayerHealth>().AddHealth(healthValue);
            Destroy(gameObject);
        }
    }
}
