using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    private float moveInput;
    public float speed;
    private bool facingRight = true;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        }

        if (facingRight == false && moveInput > 0)
        {
            Flip();

        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();

        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
