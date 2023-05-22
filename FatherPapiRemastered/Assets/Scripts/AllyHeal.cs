using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AllyHeal : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 5f;
    public float healAmount = 10f;
    public float healingDistance = 2f;

    private bool isHealing = false;
    private int initialDistance;
    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        initialDistance = Mathf.RoundToInt(Vector2.Distance(transform.position, player.position));
    }

    private void Update()
    {
        float currentDistance = Vector2.Distance(transform.position, player.position);

        if (currentDistance <= Mathf.Round(healingDistance) && !isHealing)
        {
            isHealing = true;
            HealPlayer();
        }

        if (isHealing)
        {
            MoveToPlayer();
        }
    }

    private void MoveToPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    private void HealPlayer()
    {
//public float healAmount = 10f;
    }
}

