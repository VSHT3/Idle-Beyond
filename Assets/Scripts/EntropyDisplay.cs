using TMPro;
using UnityEngine;
using BreakInfinity;

public class EntropyTracker : MonoBehaviour
{
    public TextMeshProUGUI entropyPerSecondText; // For displaying entropy per second
    public TextMeshProUGUI percentagePerSecondText; // For displaying percentage change per second

    private GameManager gameManager; // Reference to the GameManager script
    private BigDouble lastEntropy; // To track entropy value from the previous frame using BigDouble
    private float timePassed; // Time that has passed since the last check

    public double percentageChange = 0;

    void Start()
    {
        // Find the GameManager in the scene and get its reference
        gameManager = Object.FindFirstObjectByType<GameManager>();

        // Set initial values
        lastEntropy = gameManager.entropy; // Now using BigDouble
        timePassed = 0f;
    }

    void Update()
    {
        // Calculate the difference in entropy over time (per second)
        timePassed += Time.deltaTime;

        if (timePassed >= 1f)
        {
            // Calculate entropy change as BigDouble
            BigDouble entropyPerSecond = gameManager.entropy - lastEntropy;

            // Calculate percentage change using BigDouble and convert to double for the calculation
            percentageChange = lastEntropy > 0 ? (entropyPerSecond.ToDouble() / lastEntropy.ToDouble()) * 100.0 : 0.0; // Avoid division by zero

            // Display values on the UI
            entropyPerSecondText.text = "λ /s: " + BigDoubleFormatter.FormatBigDouble(entropyPerSecond); // Use formatter for display
            percentagePerSecondText.text = Mathf.RoundToInt((float)percentageChange) + "%"; // Display percentage

            // Update lastEntropy and reset timePassed
            lastEntropy = gameManager.entropy;
            timePassed = 0f;
        }
    }
}
