using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector3 startPoint;
    [SerializeField] private PlayerMovement pm;
    Rigidbody2D rb;
    float distanceToPlayer;
   
    float passiveViewDistanse = 6;
    float aggressiveViewDistanse = 8;
    float roamDistanse = 3;
    float walkSpeed = 1;
    float runSpeed = 3;
    float roamDirection = 1;

    public int facingDirX = 1;
    public bool seesPlayer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = transform.position;
        pm = FindAnyObjectByType<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        LookForPlayer();
        enemywalk();
        TurnEnemy();
    }

    void EnemyPassiveWalk ()
    {

    }
    void enemywalk()
    {
        if (seesPlayer == false)
        {
            // Flip direction when hitting patrol borders
            if (transform.position.x > startPoint.x + roamDistanse)
            {
                roamDirection = -1f;
                facingDirX = -1;
            }
            else if (transform.position.x < startPoint.x - roamDistanse)
            {
                roamDirection = 1f;
                facingDirX = 1;
            }

            rb.linearVelocity = new Vector2(roamDirection * walkSpeed, rb.linearVelocityY);
        }
        else 
        {
            if (transform.position.x < pm.transform.position.x)
            {
                rb.linearVelocityX = runSpeed;
                facingDirX = 1;
            }
            else if ((transform.position.x > pm.transform.position.x))
                {
                rb.linearVelocityX = -runSpeed;
                facingDirX = -1;
            }
        }
        
    }
    void LookForPlayer()
    {
        distanceToPlayer = Mathf.Abs(pm.transform.position.x - transform.position.x);
        if (distanceToPlayer < passiveViewDistanse)
        {
            seesPlayer = true;
        }
        else if (distanceToPlayer > aggressiveViewDistanse) { seesPlayer = false;
            
        }
    }
    void TurnEnemy()
    {
        if (facingDirX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // höger
           
        }
        else if (facingDirX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // vänster
            facingDirX = -1;
        }
    }

}
