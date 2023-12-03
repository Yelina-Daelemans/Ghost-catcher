using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    SpriteRenderer sr;
    public int damage = 1; //de 1 is de schade dat het doet

    private void Start()
    {
        // initializeert de sprite renderer op sr
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // zorgt er voor dat het object met de tag Player een leven af krijgt als die de enemy aanraakt. 
            var player = collision.gameObject.GetComponent<PlayerHealth>();
            player.TakeDamage(damage);
        }
    }
}
