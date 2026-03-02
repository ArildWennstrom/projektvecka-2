using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float dir;
    [SerializeField] Rigidbody2D rb;
    float speed = 10;
    float jumpForce = 5;
    bool jumpPressed = false;

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
        dir = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(dir * speed, rb.linearVelocity.y);
    }
    void Jump()
    { if (jumpPressed) 
        {
            
            rb.linearVelocityY = jumpForce;
            jumpPressed = false;
        }
    }
}
