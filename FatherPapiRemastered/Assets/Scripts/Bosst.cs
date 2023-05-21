using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosst : MonoBehaviour
{

    public Transform player;
    public GameObject bulletPrefab;
    public float attackRange = 5f;
    public float attackDelay = 2f;
    public float bulletSpeed = 5f;
    public float bulletRotateSpeed = 200f;

    private float attackTimer = 0f;

    void Update()
    {
        // Calculate the distance between enemy and player
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // Check if the player is within attack range
        if (distanceToPlayer <= attackRange)
        {
            // Update the attack timer
            attackTimer += Time.deltaTime;

            // Check if enough time has passed for another attack
            if (attackTimer >= attackDelay)
            {
                // Perform the attack
                Attack();
                // Reset the attack timer
                attackTimer = 0f;
            }
        }
    }

    void Attack()
    {
        // Rotate the enemy to face the player
        Vector2 direction = player.position - transform.position;
        transform.right = direction;

        // Instantiate a bullet
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // Set the bullet's velocity and rotation to follow the player
        BulletController bulletController = bullet.GetComponent<BulletController>();
        bulletController.SetTarget(player, bulletSpeed, bulletRotateSpeed);
    }
}

