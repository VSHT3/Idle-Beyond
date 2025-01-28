using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveUpgrade : MonoBehaviour
{
    public TextMeshProUGUI upgrade1Text; // For TextMeshPro support, drag your EntropyText object here in the Inspector
    public Button activeButton; // Drag your GenerateButton object here in the Inspector
    public TextMeshProUGUI upgrade1TextCost; // Drag your GenerateButton object here in the Inspector

    public int upgrade1 = 0;
    public GameManager gameManager;

    void Start()
    {
        activeButton.onClick.AddListener(buyUpgrade1);
    }

    public float upgrade1Cost = 10f; // Initial cost of the upgrade
    private float costMultiplier = 1.15f; // Scaling factor

    void buyUpgrade1()
    {
        if (gameManager.entropy >= upgrade1Cost)
        {
            gameManager.entropy -= Mathf.FloorToInt(upgrade1Cost); // Deduct the cost (rounded down to integer)
            upgrade1 += 1; // Increment the upgrade level
            upgrade1Cost *= costMultiplier; // Increase the cost for the next purchase
            UpdateUI(); // Update this script's UI
            gameManager.UpdateUI(); // Update the GameManager's UI
            gameManager.UpdateUIentropyPerClick();
        }
    }


    public int ClickUpgradeValue
    {
        get
        {
            return upgrade1 >= 1 ? 1 : 0; // Return 1 if upgrade1 >= 1, otherwise return 0
        }
    }

    public int GetClickUpgrade()
    {
        return ClickUpgradeValue * upgrade1; // Multiply base value by amount of upgrades (you can replace this with your logic)
    }


    public int upgrade1CostToText = 0;
    public void UpdateUI()
    {
        upgrade1CostToText = Mathf.FloorToInt(upgrade1Cost);
        upgrade1Text.text = upgrade1.ToString(); // Update the text
        upgrade1TextCost.text = upgrade1CostToText.ToString() + "λ";
    }
}
