using UnityEngine;
using UnityEngine.Audio;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] AudioClip HitSound;
    AudioSource audioSource;

    [SerializeField] int enemyMaxHealth = 5;
    int enemyHealth;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        enemyHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damageAmount)
    {
        enemyHealth -= damageAmount;
        print(enemyHealth);
        if (HitSound != null)
        {
            audioSource.PlayOneShot(HitSound);
        }

        if (enemyHealth < 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerFeet")) { TakeDamage(1); }
    }
}
