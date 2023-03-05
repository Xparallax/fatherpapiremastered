using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform attackSource;
    Animator myAnimation;
    private GameObject attackArea = default;

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }

        

        if(attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);

                
            }
        }
    }
    
    
  

    void Attack()
    {
        Instantiate(attackPrefab, attackSource.position, Quaternion.identity);
        myAnimation.SetTrigger("Attack");
    }    
}