using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        
        Debug.Log("plsyer death");
         SceneManager.LoadScene("GameOver");
    }
}
