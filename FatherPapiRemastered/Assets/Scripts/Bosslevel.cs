using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosslevel : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            // Destroy the boss object
            Destroy(gameObject);
            
            // Load the new scene
            SceneManager.LoadScene("CutsceneTwo");
        }
    }
}