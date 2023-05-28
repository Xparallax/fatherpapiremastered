using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform target;
    private float speed;
    private float rotateSpeed;
    public GameObject player;
    void start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void SetTarget(Transform target, float speed, float rotateSpeed)
    {
        this.target = target;
        this.speed = speed;
        this.rotateSpeed = rotateSpeed;
    }

    void Update()
   {
    
        //    // If the target is destroyed, destroy the bullet
        if (target == null)
        {
        Destroy(gameObject);
          return;
        } 

        // Move towards the target
        Vector2 direction = (target.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // Rotate to face the target
        float rotateAmount = rotateSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.right, direction, rotateAmount, 0f);
        transform.right = newDirection;
    }
      void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(other.gameObject);
        }
    }
}
