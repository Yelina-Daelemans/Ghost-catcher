using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 1;

    public SpriteRenderer EnemyRender;
    public Enemy movement;
    // Start is called before the first frame update
    void Start()
    {
        // laat de enemy starten met volledige levens
        health = maxhealth;
    }

    public void Damage(int damage)
    {
        // zorgt er voor dat als de enemy dood gaat dat die niet meer bestaat.
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
