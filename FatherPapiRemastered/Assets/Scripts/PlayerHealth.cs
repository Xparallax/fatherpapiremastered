using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : Health

    
{
    public int maxHealth = 350;
    public int currentHealth;

public HealthBar healthBar; 

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

void TakeDamage(int damage)
 {
      // The following line ensures that currentHealth is minimum 0 (avoid negative number)
      currentHealth = Mathf.Max(0, currentHealth - damage);
      healthBar.setHealth(currentHealth);
      if (currentHealth == 0)
           Destroy(gameObject);
 }

    protected override void Die()
    {
        
        Debug.Log("plsyer death");
         SceneManager.LoadScene("GameOver2");
    }
}
