using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float gravity = 10f;
    float velUp = 3;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = velUp;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityY -=gravity*Time.deltaTime;
    }
}
