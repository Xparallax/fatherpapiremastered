using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2f);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Does nothing if we hit the player.
        if (collision.gameObject.tag == "Player") return;

        Health healthScript = collision.gameObject.GetComponent<Health>();
        if (healthScript != null)
        {
            healthScript.Damage(30);
        }

        Destroy(gameObject);
    }
}
