using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Objectkill : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object is the player or an enemy
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            // Destroy the collided object
            Destroy(other.gameObject);
        }
    }
}
