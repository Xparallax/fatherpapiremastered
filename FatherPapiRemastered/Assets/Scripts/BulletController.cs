using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform target;
    private float speed;
    private float rotateSpeed;

    public void SetTarget(Transform target, float speed, float rotateSpeed)
    {
        this.target = target;
        this.speed = speed;
        this.rotateSpeed = rotateSpeed;
    }

    void Update()
    {
        if (target == null)
        {
            // If the target is destroyed, destroy the bullet
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
}
