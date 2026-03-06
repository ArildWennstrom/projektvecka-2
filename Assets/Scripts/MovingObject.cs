using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] PlayerMovement pm;

    [SerializeField] float leftSide;
    [SerializeField] float rightSide;
    
    [SerializeField] float topSide;
    [SerializeField] float bottomSide;
    [SerializeField] float acceleration;
    [SerializeField] float speed;
  
   Rigidbody2D rb;
       [SerializeField] Vector2 moveDirection = new Vector2 (1, 1);

    bool hasPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        MovePlayer();
    }
    void Move()
    {
       

        if (moveDirection.x != 0) 
        {
            if (transform.position.x > rightSide) { moveDirection.x = -1; }
            else if (transform.position.x < leftSide) { moveDirection.x = 1; }
        }
        if (moveDirection.y != 0)
        {
            if (transform.position.y > topSide) { moveDirection.y = -1; }
            else if (transform.position.y < bottomSide) { moveDirection.y = 1; }
        }
       



        Vector2 targetVelocity = moveDirection * speed;
        if (moveDirection.x < targetVelocity.x)
        {
            moveDirection.x += acceleration * Time.deltaTime;
        }
        else if (moveDirection.x > targetVelocity.x)
        {
            moveDirection.x -= acceleration* Time.deltaTime;
        }
        if (moveDirection.y < targetVelocity.y)
        {
            moveDirection.y += acceleration * Time.deltaTime;
        }
        else if (moveDirection.y > targetVelocity.y)
        {
            moveDirection.y -= acceleration * Time.deltaTime;
        }

        rb.linearVelocity = moveDirection;
    }
    void MovePlayer()
    {
        
        Vector3 pos = pm.transform.position;
        pos.x = transform.position.x;
        pos.y = pm.transform.position.y;
        if (hasPlayer) { pm.transform.position = pos; }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            hasPlayer = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            hasPlayer = false;
        }
    }
}
