using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{

    public GameObject objectPrefab;
    public Transform player;
    public float warningTime = 3f;
    public float damageDuration = 5f;
    public float fallInterval = 2f;
    public float fallSpeed = 5f;
    public float damageAmount = 10f;

    private bool isFalling = false;

    void Start()
    {
        Invoke("StartFalling", warningTime);
    }

    void StartFalling()
    {
        isFalling = true;
        InvokeRepeating("SpawnObject", 0f, fallInterval);
        Invoke("StopFalling", damageDuration);
    }

    void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-10f, 10f), 10f);
        GameObject fallingObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = fallingObject.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * fallSpeed;
    }

    void StopFalling()
    {
        isFalling = false;
        CancelInvoke("SpawnObject");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("fall -- Other:"+other+". isFalling:"+isFalling);
        if (other.CompareTag("Player"))
        {
            //Apply damage to the player
           PlayerHealth Health = other.GetComponent<PlayerHealth>();
           Debug.Log("bone hit player"+Health);
           
          //  if (Health != null)
         //  {
          //     Health.TakeDamage(damageAmount);
          // }
        }
   }
}
