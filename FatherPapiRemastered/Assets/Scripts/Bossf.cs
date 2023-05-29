using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bossf : MonoBehaviour
{
    public float movementSpeed = 2f;
    public float invincibleDuration = 3f;
    public float flyDuration = 5f;
    public float fallSpeed = 10f;

    private bool isInvincible = false;
    private Renderer bossRenderer;

    private void Start()
    {
        bossRenderer = GetComponent<Renderer>();
        StartCoroutine(BossActions());
    }

    private IEnumerator BossActions()
    {
        while (true)
        {
            yield return MoveToRandomPosition();

            // Boss becomes invincible
            isInvincible = true;
            bossRenderer.material.color = Color.black;

            yield return new WaitForSeconds(invincibleDuration);

            // Boss is vulnerable again
            isInvincible = false;
            bossRenderer.material.color = Color.white;

            // Boss flies for a duration
            yield return Fly();

            // Boss falls down
            yield return Fall();
        }
    }

    private IEnumerator MoveToRandomPosition()
    {
        Vector2 targetPosition = GetRandomPosition();
        while (Vector2.Distance(transform.position, targetPosition) > 0.1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            yield return null;
        }
    }

    private Vector2 GetRandomPosition()
    {
        
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);
        return new Vector2(x, y);
    }

    private IEnumerator Fly()
    {
        // Implement your logic for the boss to fly
        // For example, move the boss upwards for the specified duration
        float startTime = Time.time;
        while (Time.time - startTime < flyDuration)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            yield return null;
        }
    }

    private IEnumerator Fall()
    {
        
        while (transform.position.y > -10f)
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
            yield return null;
        }
    }

 
    public int sceneName = 10;

    // Other boss-related code
 private void Die()
    {
        if (gameObject.CompareTag("God"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}

