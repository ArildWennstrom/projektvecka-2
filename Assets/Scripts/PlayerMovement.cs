using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float dirX;
    [SerializeField] Rigidbody2D rb;
    float speed = 10;
    float jumpForce = 5;
    bool jumpPressed = false;
    // facingdirections: 1 = vänster, 2 = höger, 3 = ned, 4 = upp
    public int facingDirectionX = 1;
    public bool isGrounded = false;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (jumpPressed == false && Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
            Jump();
        }
        dirX = Input.GetAxisRaw("Horizontal");
        if (dirX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // höger
            facingDirectionX = 1;
        }
        else if (dirX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // vänster
            facingDirectionX = -1;
        }


        rb.linearVelocity = new Vector2(dirX * speed, rb.linearVelocity.y);
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
}