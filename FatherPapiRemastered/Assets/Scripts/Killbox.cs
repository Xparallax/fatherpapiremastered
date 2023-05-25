using UnityEngine;

public class Killbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy the object that collided with this deadly object
        Destroy(other.gameObject);
    }
}
