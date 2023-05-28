using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class fatherpapidestroy : MonoBehaviour
{
public string level; 

    // ...

    void OnDestroy()
    {
        // Check if the boss GameObject is being destroyed
        if (gameObject.CompareTag("God"))
        {
            // Transition to the next scene
            SceneManager.LoadScene("CutsceneThree");
        }
    }
}
