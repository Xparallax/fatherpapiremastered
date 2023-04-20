using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : Health

    
{
    public int maxHealth = 500;
    public int currentHealth;
    public int newhealth;
    public int sliderHealth;
    public HealthBar healthBar; 
    public Health actualHp;
    private GameObject player;
 

    void Start()
    {
        GetComponent<Health>().SetHealth(maxHealth, maxHealth);
    }

  void Update()
 {
      // The following line ensures that currentHealth is minimum 0 (avoid negative number)
      currentHealth = GetComponent<Health>().getHealth();
      healthBar.updateHp(currentHealth);
      if (currentHealth <= 0)
           Destroy(gameObject);
      
 }
 public int getMaxHealth(){

    return maxHealth;


 }
  public int getCurrentHealth(){

    return currentHealth;


 }

    protected override void Die()
    {
        
        Debug.Log("plsyer death");
         SceneManager.LoadScene("GameOver2");
    }


   // public Update(){
        // access player object
        // access health from other script
        // update health here
   // }
}
