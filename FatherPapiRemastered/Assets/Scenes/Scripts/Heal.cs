using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;    
    }
  public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player");
            {
                var healthComponent = collision.GetComponent<Health>();
                if(healthComponent != null)
                {
                    healthComponent.Heal(3);
                }
                
            }
        }

    
}
