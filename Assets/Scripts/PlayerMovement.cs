using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float dirX;
    [SerializeField] Rigidbody2D rb;
    float speed = 5;
    float crouchSpeed = 2;
    float jumpForce = 5;
    bool jumpPressed = false;
    // facingdirections: 1 = vänster, 2 = höger, 3 = ned, 4 = upp
    public int facingDirX = 1;
    public bool isGrounded = false;
    public bool isCrouching = true;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckForJumping();
        CheckForCrouching();
        dirX = Input.GetAxisRaw("Horizontal");
        TurnPlayer();

        if (isCrouching) { rb.linearVelocity = new Vector2(dirX * crouchSpeed, rb.linearVelocity.y); }
        else { rb.linearVelocity = new Vector2(dirX * speed, rb.linearVelocity.y);  }
           
    }
    void CheckForCrouching()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = true;
            transform.localScale = new Vector3(1, 0.4f, 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouching = false;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    void CheckForJumping()
    {
        if (jumpPressed == false && Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
            Jump();
        }
    }

    void Jump()
    {
        if (jumpPressed && isGrounded)
        {

            rb.linearVelocityY = jumpForce;
            jumpPressed = false;
            
        }
        else { jumpPressed = false; }
    }
    void TurnPlayer()
    {
        if (dirX > 0)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z); // höger
            facingDirX = 1;
        }
        else if (dirX < 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z); // vänster
            facingDirX = -1;
        }
    }
   public void Bounce()
    {
        rb.linearVelocityY = jumpForce;

    }
}