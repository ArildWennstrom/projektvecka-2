using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMovement pm;
    int playerMaxHealth = 5;
    int playerHealth = 5;
    int Score = 0;
    Vector3 spawnpoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpoint = pm.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pause med ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

        
    }

   public void Restart()
    {
        transform.position = spawnpoint;
        playerHealth = playerMaxHealth;


    }
    void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if (playerHealth < 1) { Restart(); }
    }
    void AddScore(int scoreAddAmount)
    {
        Score += scoreAddAmount;
    }
    void calcHealth()
    {

    }

    void Pause()
    {

    }
   
    void Poäng()
    {

    }

}
