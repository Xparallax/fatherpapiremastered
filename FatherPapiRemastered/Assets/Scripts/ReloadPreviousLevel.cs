using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadPreviousLevel : MonoBehaviour
{
    private string previousSceneName;

    void Start()
    {
        // Get the name of the previous scene
        previousSceneName = SceneManager.GetActiveScene().name;
        Debug.Log("nextscene:"+previousSceneName);
    }

    void OnDestroy()
    {
        Debug.Log("nextscene:"+previousSceneName);
        Debug.Log("GAMEOBJECT:"+gameObject.CompareTag("Player"));


        // Check if the destroyed object is the player
        if (gameObject.CompareTag("Player"))
        {
            // Reload the previous level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
