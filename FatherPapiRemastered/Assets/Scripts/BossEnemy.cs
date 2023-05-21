using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    public Transform player;
    public float dashSpeed = 10f;
    public float dashInterval = 5f;
    public float dashDuration = 0.5f;
    public float dashCooldown = 2f;
    public float jumpForce = 5f;
    public float jumpInterval = 3f;
    public float jumpCooldown = 2f;

    private bool isDashing = false;
    private bool canDash = true;
    private bool isJumping = false;
    private bool canJump = true;
    private Rigidbody2D rb;

    void Start()
    {
        InvokeRepeating("Dash", dashInterval, dashCooldown);
        InvokeRepeating("Jump", jumpInterval, jumpCooldown);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDashing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * dashSpeed * Time.deltaTime);
        }
    }

    void Dash()
    {
        if (!isDashing && canDash)
        {
            isDashing = true;
            Invoke("StopDashing", dashDuration);
        }
    }

    void StopDashing()
    {
        isDashing = false;
    }

    void Jump()
    {
        if (!isJumping && canJump && !isDashing)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

