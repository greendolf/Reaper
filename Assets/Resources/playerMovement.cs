using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Physics2D;

public class playerMovement : MonoBehaviour
{
    public float horizSpeed = 1f;
    public float vertSpeed = 1f;
    public float jumpForce = 5f;
    private float dir;

    //private int jumpCount;
    private int extraJump;
    private bool isGrounded = false;
    public Transform feetPos;
    public float radius = 0.3f;
    public LayerMask Ground;
    //public Transform player;
     
    private bool facingRight = false;

    private Rigidbody2D rb;
    // Start is called before the first frame update

    /*void Jump()
    {
        //rb.AddForce(transform.up* jumpForce, ForceMode2D.Impulse);
        rb.velocity = Vector2.up * jumpForce;
    }*/

    private void OnGround()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, radius, Ground);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler; 

    }


void Start()
    {
        //transform.localScale.x *= -1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("Horizontal"))
        
            dir = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(dir * horizSpeed, rb.velocity.y);
            //transform.position = Vector3.MoveTowards(transform.position, transform.position + horizDir, horizSpeed * Time.deltaTime);
        

        /*if (Input.GetButton("Vertical"))
        {
            Vector3 vertDir = transform.up * Input.GetAxis("Vertical");
            //rb.AddForce(dir * speed, ForceMode2D.Impulse);
            transform.position = Vector3.MoveTowards(transform.position + vertDir, transform.position, vertSpeed * Time.deltaTime);
        }*/

        if(isGrounded == true)
        {
            extraJump = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            //Jump();
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }

        if (facingRight == false && dir > 0)
        {
            Flip();
        }
        else if (facingRight == true && dir < 0)
        {
            Flip();
        }
    }
    
    void FixedUpdate()
    {
        OnGround();
    }
}
