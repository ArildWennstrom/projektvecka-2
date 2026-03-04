using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMovement pm;
    int playerMaxHealth = 5;
    int playerHealth = 5;
    int score = 0;
    int highScore;
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
            Restart();
        }

        
    }

   public void Restart()
    {
        pm.transform.position = spawnpoint;
        playerHealth = playerMaxHealth;
        if (score > highScore) { highScore = score; }
        score = 0;
     

    }
    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if (playerHealth < 1) { Restart(); }
        print(playerHealth);
    }
    public void AddScore(int scoreAddAmount)
    {
        score += scoreAddAmount;
      
    }
   

   
   
    void Poäng()
    {

    }

}
