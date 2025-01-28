using TMPro;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI entropyText; // For TextMeshPro support, drag your EntropyText object here in the Inspector
    public Button generateButton; // Drag your GenerateButton object here in the Inspector
    public Button reset; // Drag your Reset object here in the Inspector
    public TextMeshProUGUI entropyPerClickText;

    public ActiveUpgrade activeUpgrade;

    public BigDouble entropy = 1; // Tracks the amount of entropy using BigDouble

    void Start()
    {
        // Set up the button click functionality
        generateButton.onClick.AddListener(GenerateEntropy);
        reset.onClick.AddListener(ResetEntropy);
        UpdateUI(); // Initialize the UI on start
    }

    private int entropyPerClick = 0; // Used for calculating the increment per click

    void GenerateEntropy()
    {
        int upgrade1inc = activeUpgrade.GetClickUpgrade();
        entropy += 1 + upgrade1inc; // Now using BigDouble for the entropy
        UpdateUI();   // Update the displayed text
    }

    void ResetEntropy()
    {
        entropy = 3000; // Reset entropy count to a BigDouble value
        activeUpgrade.upgrade1 = 0;
        UpdateUI();   // Update the displayed text
        activeUpgrade.UpdateUI();
    }

    public void UpdateUI()
    {
        // Format the entropy using the BigDoubleFormatter
        string formattedEntropy = BigDoubleFormatter.FormatBigDouble(entropy);
        entropyText.text = "Entropy: " + formattedEntropy + " λ"; // Display BigDouble
    }

    public void UpdateUIentropyPerClick()
    {
        int upgrade1inc = activeUpgrade.GetClickUpgrade();
        entropyPerClick = 1 + upgrade1inc;
        entropyPerClickText.text = entropyPerClick + " λ/c"; // Update the text for entropy per click
    }
}