using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossA : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform player;
    public float throwInterval = 2f;
    public float throwForce = 10f;

    private bool isThrowing = false;

    void Start()
    {
        InvokeRepeating("Throw", throwInterval, throwInterval);
    }

    void Throw()
    {
        if (!isThrowing)
        {
            // Instantiate and throw projectiles towards the player
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Vector2 direction = (player.position - transform.position).normalized;
            Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
            projectileRb.AddForce(direction * throwForce, ForceMode2D.Impulse);

            // Set throwing flag and schedule stop throwing
            isThrowing = true;
            Invoke("StopThrowing", 0.5f);
        }
    }



    void StopThrowing()
    {
        isThrowing = false;
    }

 private void Die()
    {
        if (gameObject.CompareTag("God"))
        {
            SceneManager.LoadScene("Inbetween");
        }
    }
}
