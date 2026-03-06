using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f; // Pausar spelet
        }
    }
}