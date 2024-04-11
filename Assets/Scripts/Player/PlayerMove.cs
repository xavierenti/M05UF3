using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb;


    public float fallMultiplayer = 0.5f;
    public float lowMultiplayer = 1f;


    public bool isGrounded = true;

    SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
            sr.flipX = false;
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-runSpeed, rb.velocity.y);
            sr.flipX = true;
        }
        if (Input.GetKey("w") && isGrounded)
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplayer) * Time.deltaTime;
            }
            else if(rb.velocity.y > 0 && !Input.GetKey("w"))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowMultiplayer) * Time.deltaTime;
            }

            //rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Flor"))
        {
            isGrounded = true;
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
