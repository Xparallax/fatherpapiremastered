using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelthreefix : MonoBehaviour

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
            SceneManager.LoadScene("CutsceneThree");
        }
    }
}
