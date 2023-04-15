using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;
  


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
           // Damage(10);
        }   

        if (Input.GetKeyDown(KeyCode.H))
        {
             //Heal(10);
        }
    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    private  IEnumerator VisualIndicator(Color color)
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        
        sp.color = color;
        yield return new WaitForSeconds(0.15f);
        sp.color = Color.white;
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
            
        }

        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));

        if(health <= 0)
        {
            
            Die();
        }

      
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negatice healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;
        StartCoroutine(VisualIndicator(Color.green));


        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else 
        {
            this.health += amount;
        }

        this.health += amount;
    }

    
    

    protected virtual void Die()
    {
        
        Debug.Log("death");
        Destroy(gameObject);
        GetComponent<LootBag>().InstantiateLoot(transform.position);
    }
     
}
