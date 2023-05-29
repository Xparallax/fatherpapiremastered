using UnityEngine;
using UnityEngine.SceneManagement;

public class previousScenename : MonoBehaviour
{
    private string previousSceneName;

    void Start()
    {
        // Get the name of the previous scene
        previousSceneName = SceneManager.GetActiveScene().name;
    }

    void OnDestroy()
    {
        // Check if the destroyed object is the player
        if (gameObject.CompareTag("Player"))
        {
            // Reload the previous level
           // SceneManager.LoadScene(previousSceneName);
        }
    }
}
