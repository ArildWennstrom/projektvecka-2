using UnityEngine;
using TMPro;

public class PlayerLives : MonoBehaviour
{
    public int maxLives = 5;
    private int currentLives;

    public TextMeshProUGUI heartText;

    void Start()
    {
        currentLives = maxLives;
        UpdateUI();
    }

    public void TakeDamage()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateUI();
        }

        if (currentLives <= 0)
        {
            Die();
        }
    }

    void UpdateUI()
    {
        heartText.text = currentLives.ToString();
    }

    void Die()
    {
        Debug.Log("Game Over!");
        // Här kan du lägga respawn eller scenbyte
    }
}