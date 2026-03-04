using UnityEngine;

public class EnemyCollisionDetect : MonoBehaviour
{
    [SerializeField]EnemyManager em;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            em.TakeDamage(1);
        }
    }
    }
