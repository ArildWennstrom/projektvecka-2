using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] GameManager gm;
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
            gm.TakeDamage(1);
        }
    }
}
