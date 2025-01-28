using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;

public class DotManager : MonoBehaviour
{
    public GameObject dotPrefab; // Assign the Dot prefab in the Inspector
    private GameManager gameManager; // Reference to the GameManager
    private int currentDotCount = 0;
    private bool isFirstDotSpawned = false; // Flag to track if the first dot has been spawned

    public Button spawnButton; // Reference to the button to spawn the first dot

    void Start()
    {
        // Find the GameManager in the scene
        gameManager = Object.FindFirstObjectByType<GameManager>();

        // Add listener to the button
        if (spawnButton != null)
        {
            spawnButton.onClick.AddListener(SpawnFirstDot);
        }
    }

    void Update()
    {
        if (gameManager != null && isFirstDotSpawned)
        {
            // Calculate the number of dots based on the number of digits in entropy
            int newDotCount = gameManager.entropy.ToString("F0").Length;

            // Spawn additional dots if necessary
            if (newDotCount > currentDotCount)
            {
                for (int i = currentDotCount; i < newDotCount; i++)
                {
                    SpawnDot();
                }
                currentDotCount = newDotCount;
            }
        }
    }

    private void SpawnFirstDot()
    {
        if (!isFirstDotSpawned) // Only allow the first dot to spawn once
        {
            SpawnDot();
            isFirstDotSpawned = true;
        }
    }

    private void SpawnDot()
    {
        // Determine a random edge position to spawn the dot
        Vector3 randomPosition = GetRandomEdgePosition();
        GameObject dot = Instantiate(dotPrefab, randomPosition, Quaternion.identity);

        // Add the DotMovement script to the dot
        DotMovement dotMovement = dot.AddComponent<DotMovement>();

        // Optionally, set speed or other properties here
        dotMovement.currentSpeed = Random.Range(1f, 3f); // Random speed for variety

        // Increment the current dot count
        currentDotCount++;
    }

    private Vector3 GetRandomEdgePosition()
    {
        // Get the camera's viewport size
        float screenWidth = Camera.main.orthographicSize * Camera.main.aspect;
        float screenHeight = Camera.main.orthographicSize;

        // Randomly choose an edge to spawn the dot
        int edge = Random.Range(0, 4); // 0: left, 1: right, 2: top, 3: bottom

        switch (edge)
        {
            case 0: // Left edge
                return new Vector3(-screenWidth, Random.Range(-screenHeight, screenHeight), 0);
            case 1: // Right edge
                return new Vector3(screenWidth, Random.Range(-screenHeight, screenHeight), 0);
            case 2: // Top edge
                return new Vector3(Random.Range(-screenWidth, screenWidth), screenHeight, 0);
            case 3: // Bottom edge
                return new Vector3(Random.Range(-screenWidth, screenWidth), -screenHeight, 0);
            default:
                return Vector3.zero; // Fallback
        }
    }
}
