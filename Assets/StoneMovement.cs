using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovement : MonoBehaviour
{

    public float speed;
    private float moveInput;
    public Rigidbody2D rb;
    public Animator anim;
    public bool addForce = false;
    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
     
            
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            anim.enabled = true;


        }
       



        moveInput = Input.GetAxis("Horizontal");

        if (addForce == true)
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


    void StopMovement()
    {

        addForce = false;
        anim.enabled = false;
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    void StartMovement()
    {

        addForce = true;

    }

}
