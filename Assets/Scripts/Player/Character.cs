using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class Character : MonoBehaviour
{
    private bool isFacingRight = true;
    private Rigidbody2D Rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;

    [SerializeField] float Speed = 5f;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

        // zorgt er voor dat de speler kan bewegen
        Rb.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, Rb.velocity.y);
        
        Flip();
    }
    private void Flip()
    {
        if (isFacingRight && Rb.velocity.x < 0f || !isFacingRight && Rb.velocity.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}
