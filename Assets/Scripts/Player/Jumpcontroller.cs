using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpcontroller : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField] private LayerMask jumpableGround;
    private BoxCollider2D coll;
    [SerializeField] private float jumpForce = 14f;
    void Start()
    {
            rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    void Update()
    { 
        //met deze code kan de speler niet meerdere keren springen in de lucht en kan die pas terug springen als die de grond raakt
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private bool IsGrounded()
    {
        //dit is de code dat nachecked of dat de speler op de grond is geland of niet
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
