using UnityEngine;

public class DotMovement : MonoBehaviour
{
    public float minSpeed = 0.3f; // Minimum speed
    public float maxSpeed = 999999f; // Maximum speed
    public float acceleration = 1f; // Acceleration rate
    public float deceleration = 1.7f; // Deceleration rate
    public float currentSpeed; // Current speed of the dot
    private Vector2 direction;

    // Reference to the EntropyTracker component (automatically found)
    private EntropyTracker entropyTracker;

    void Start()
    {
        // Randomize the initial direction
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        // Find the EntropyTracker component in the scene
        entropyTracker = Object.FindFirstObjectByType<EntropyTracker>();

        // Initialize current speed
        currentSpeed = minSpeed; // Start at minimum speed
    }

    void Update()
    {
        // Ensure speed is equal to percentageChange from EntropyTracker
        if (entropyTracker != null)
        {
            float targetSpeed = Mathf.Clamp((float)entropyTracker.percentageChange / 2, minSpeed, maxSpeed);

            // Accelerate or decelerate towards the target speed
            if (currentSpeed < targetSpeed)
            {
                currentSpeed += acceleration * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, targetSpeed); // Cap to target speed
            }
            else if (currentSpeed > targetSpeed)
            {
                currentSpeed -= deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, targetSpeed); // Cap to target speed
            }
        }

        // Move the dot
        transform.Translate(direction * currentSpeed * Time.deltaTime);

        // Check for screen bounds
        Vector3 screenPos = Camera.main.WorldToViewportPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > 1)
        {
            direction.x = -direction.x; // Bounce off the left/right edges
        }
        if (screenPos.y < 0 || screenPos.y > 1)
        {
            direction.y = -direction.y; // Bounce off the top/bottom edges
        }
    }
}