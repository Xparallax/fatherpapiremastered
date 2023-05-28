using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public Transform targetLocation1; // The first target location where the boss goes down
    public Transform targetLocation2; // The second target location where the boss rises up
    public float moveSpeed = 5f; // The speed at which the boss moves
    public float waitTime = 2f; // The time the boss waits at each location

    private bool isMovingDown = true; // Flag to track if the boss is currently moving down
    private bool isMoving = false; // Flag to track if the boss is currently moving
    private Vector3 currentTarget; // The current target location for the boss

    private void Start()
    {
        currentTarget = targetLocation1.position;
    }

    private void Update()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveBoss());
        }
    }

    private System.Collections.IEnumerator MoveBoss()
    {
        isMoving = true;

        // Move to the current target location
        while (transform.position != currentTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentTarget, moveSpeed * Time.deltaTime);
            yield return null;
        }

        // Wait at the current location
        yield return new WaitForSeconds(waitTime);

        // Switch to the next target location
        if (isMovingDown)
        {
            currentTarget = targetLocation2.position;
        }
        else
        {
            currentTarget = targetLocation1.position;
        }

        // Toggle the moving direction
        isMovingDown = !isMovingDown;

        isMoving = false;
    }
}
