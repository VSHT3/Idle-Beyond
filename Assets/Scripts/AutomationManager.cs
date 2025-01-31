using UnityEngine;
using UnityEngine.UI;
using TMPro;
using BreakInfinity;

public class AutomationManager : MonoBehaviour
{
    public PassiveUpgrade passiveUpgrade;

    public float autobuyerCooldown = 1f; // Time interval for passive entropy gain
    private float autobuyerCooldownNow = 0f; // Time for the next entropy gain
    public Toggle autobuyerToggle;
    public Image autobuyerBackground;
    public Button autobuyerUpgradeButton;
    public TextMeshProUGUI autobuyerUpgradeTextCost; // Drag your UI element for showing cost here
    public TextMeshProUGUI cooldownText; // Drag your UI element for showing cost here

    public BigDouble autobuyerUpgradeCost = 100f;
    private BigDouble costMultiplier = 10f; // Cost scaling factor

    public GameManager gameManager; // Reference to your GameManager script

    void Start()
    {
        autobuyerUpgradeButton.onClick.AddListener(UpgradeCooldown);
        UpdateUI(); // Initialize the UI on start
    }

    void Update()
    {
        // Update the background color based on the toggle state
        autobuyerBackground.color = autobuyerToggle.isOn ? Color.green : Color.red;

        // Check if the autobuyer is active and the cooldown has elapsed
        if (Time.time >= autobuyerCooldownNow && autobuyerToggle.isOn)
        {
            passiveUpgrade.BuyExponentUpgrade1();
            passiveUpgrade.UpdateUI();
            autobuyerCooldownNow = Time.time + autobuyerCooldown;
        }
    }

    void UpgradeCooldown()
    {
        if (gameManager.entropy >= autobuyerUpgradeCost)
        {
            gameManager.entropy -= autobuyerUpgradeCost; // Deduct the cost
            autobuyerCooldown *= 0.8f; // Decrease the cooldown
            autobuyerUpgradeCost *= costMultiplier; // Increase the cost for the next level
            UpdateUI(); // Update the UI to reflect the new state
            gameManager.UpdateUI(); // Update the main game UI
        }
    }

    void UpdateUI()
    {
        // Update the text for the autobuyer upgrade cost
        string formattedUpgradeCost = BigDoubleFormatter.FormatBigDouble(autobuyerUpgradeCost);
        autobuyerUpgradeTextCost.text = $"{formattedUpgradeCost} λ"; // Update the cost text

        cooldownText.text = $"{autobuyerCooldown:F2} seconds"; // Assuming you have a cooldownText variable
    }
}