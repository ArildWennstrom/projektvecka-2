using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    
   
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
        if (collision.CompareTag("Player"))
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            int nextScene = currentScene + 1;
            SceneManager.LoadScene(nextScene);

        }
    }
}
