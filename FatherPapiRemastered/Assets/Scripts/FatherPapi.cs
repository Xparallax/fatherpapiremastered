using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherPapi : MonoBehaviour
{
    public Transform player;
    public float throwInterval = 2f;
    public float throwForce = 10f;
    public float throwDuration = 10f;
    public float jumpForce = 5f;
    public float runAwayDistance = 10f;
    public float runAwayDuration = 3f;
    public int lowHealthThreshold = 30;

    private bool isThrowing = false;
    private bool isJumping = false;
    private bool isRunningAway = false;
    private int initialHealth;

    //void Start()
  //  {
       // InvokeRepeating("Throw", throwInterval, throwDuration);
        //initialHealth = GetComponent<God>().GetCurrentHealth();
  //  }

   // void Update()
   // {
       // if (!isThrowing && !isJumping && !isRunningAway)
        //{
           // int currentHealth = GetComponent<God>().GetCurrentHealth();
           // if (currentHealth < initialHealth * (lowHealthThreshold / 100f))
           // {
          //      isRunningAway = true;
          //      Invoke("StopRunningAway", runAwayDuration);
          //  }
       // }
   // }

 //   void Throw()
 //   {
      //  if (!isThrowing && !isJumping && !isRunningAway)
      //  {
            // Instantiate and throw objects towards the player
          //  GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        //    Vector2 direction = (player.position - transform.position).normalized;
         //   Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
         //   projectileRb.AddForce(direction * throwForce, ForceMode2D.Impulse);

            // Set throwing flag and schedule stop throwing
          ////  isThrowing = true;
          //  Invoke("StopThrowing", throwDuration);
     //   }
   // }

    void StopThrowing()
    {
        isThrowing = false;
    }

    void StopRunningAway()
    {
        isRunningAway = false;
    }
}
