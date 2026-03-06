<<<<<<< HEAD
=======
using UnityEngine;

public class PlayerCollisionDetect : MonoBehaviour
{
    PlayerMovement pm;
    [SerializeField] GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pm = GetComponentInParent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("WeakSpot"))
        {
          
            pm.Bounce();
        }
    }
   
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            gm.TakeDamage(1);
        }
    }

}
>>>>>>> 13c7ad672502f73e47f2971d99d914e3763c4fa4
