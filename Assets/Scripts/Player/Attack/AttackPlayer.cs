using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    public int damage = 1; // zorgt er voor dat de hamer maar 1 schade doed

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // zorgt er voor dat als de spoken met de boxcollider van de hamer in aanraking komen dat die dan de hoeveelheid schade krijgen van wat er is ingestelt als hoeveelheid schade
        if(collision.gameObject.tag == "Enemy")
        {
            var Enemy = collision.gameObject.GetComponent<EnemyHealth>();
            Enemy.Damage(damage);
        }
        
    }
}
