using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;


    [SerializeField] private LayerMask ground;
    [SerializeField] private float speed;

    private int direction;
    private float scaleX;

    // Start is called before the first frame update
    void Start()
    {
        // roept component op vanuit de rigidbode2D
        rb = GetComponent<Rigidbody2D>();
        // roept component op vanuit de Boxcollider2D
        coll = GetComponent<BoxCollider2D>();
        // roept component op vanuit de animator
        anim = GetComponent<Animator>();


        if (UnityEngine.Random.Range(0, 2) == 0)
        {
            direction = -1;
           // zorgt er voor dat de enemy naar de andere kant gaat wanneer dat het op het einde van zijn baan is.
        }
        else
        {
            direction = 1;
            // zorgt er voor dat het van de ene naar de andere kant gaat
        }

        // zorgt er voor dat de enemy naar voor blijft kijken ook al gaat die de andere richting uit
        scaleX = Math.Abs(transform.localScale.x);
        // abs = absoluut
        transform.localScale = new Vector3(scaleX * direction, transform.localScale.y, transform.localScale.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        // zorgt er voor dat de positie van de enemy juist blijft
        Vector2 position = transform.position;
        // zorgt er voor dat die op een bepaalde snelheid blijft wandelen.
        position.x += Time.deltaTime * speed * direction;
        transform.position = position;

        if (!WalkableSurface())
        {
            direction = -direction;
            transform.localScale = new Vector3(scaleX * direction, transform.localScale.y, transform.localScale.z);
        }
    }

    private bool WalkableSurface()
    {
        Vector2 position = coll.bounds.center;
        position.x += coll.bounds.size.x * direction;
        return Physics2D.BoxCast(position, coll.bounds.size, 0f, Vector2.down, 0.1f, ground);
        //Boxcast is een denkbeeldige doos
    }
}
