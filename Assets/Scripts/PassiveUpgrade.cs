using TMPro;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;

public class PassiveUpgrade : MonoBehaviour
{
    public TextMeshProUGUI upgradeText; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText; // Drag your UI element for showing cost here
    public Button purchaseButton; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText2; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText2; // Drag your UI element for showing cost here
    public Button purchaseButton2; // Drag the button here in the Inspector
    public BigDouble upgradeLevel2 = 0;
    public BigDouble upgradeCost2 = 10f;

    public TextMeshProUGUI upgradeText3; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText3; // Drag your UI element for showing cost here
    public Button purchaseButton3; // Drag the button here in the Inspector
    public BigDouble upgradeLevel3 = 0;
    public BigDouble upgradeCost3 = 100f;

    public TextMeshProUGUI upgradeText4; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText4; // Drag your UI element for showing cost here
    public Button purchaseButton4; // Drag the button here in the Inspector
    public BigDouble upgradeLevel4 = 0;
    public BigDouble upgradeCost4 = 100f;

    public TextMeshProUGUI upgradeText5; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText5; // Drag your UI element for showing cost here
    public Button purchaseButton5; // Drag the button here in the Inspector
    public BigDouble upgradeLevel5 = 0;
    public BigDouble upgradeCost5 = 100f;

    public BigDouble upgradeLevel = 0; // Current level of the upgrade
    public BigDouble upgradeCost = 10f; // Initial cost of the upgrade
    private BigDouble costMultiplier = 1.15f; // Cost scaling factor

    public GameManager gameManager; // Reference to your GameManager script

    private float entropyGainInterval = 1f; // Time interval for passive entropy gain
    private int entropyGainAmount = 1; // Amount of entropy gained per interval
    private float nextEntropyGainTime = 0f; // Time for the next entropy gain

    public BigDouble upgradeLevel6 = 0;
    public BigDouble upgradeCost6 = 100f;

    public BigDouble upgradeLevel7 = 0;
    public BigDouble upgradeCost7 = 100f;

    public BigDouble upgradeLevel8 = 0;
    public BigDouble upgradeCost8 = 100f;

    public BigDouble upgradeLevel9 = 0;
    public BigDouble upgradeCost9 = 100f;

    public BigDouble upgradeLevel10 = 0;
    public BigDouble upgradeCost10 = 100f;

    public BigDouble upgradeLevel11 = 0;
    public BigDouble upgradeCost11 = 100f;

    public BigDouble upgradeLevel12 = 0;
    public BigDouble upgradeCost12 = 100f;

    public BigDouble upgradeLevel13 = 0;
    public BigDouble upgradeCost13 = 100f;

    public BigDouble upgradeLevel14 = 0;
    public BigDouble upgradeCost14 = 100f;

    public BigDouble upgradeLevel15 = 0;
    public BigDouble upgradeCost15 = 100f;

    public BigDouble upgradeLevel16 = 0;
    public BigDouble upgradeCost16 = 100f;

    public BigDouble upgradeLevel17 = 0;
    public BigDouble upgradeCost17 = 100f;

    public BigDouble upgradeLevel18 = 0;
    public BigDouble upgradeCost18 = 100f;

    public BigDouble upgradeLevel19 = 0;
    public BigDouble upgradeCost19 = 100f;

    public BigDouble upgradeLevel20 = 0;
    public BigDouble upgradeCost20 = 100f;

    public TextMeshProUGUI upgradeText6; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText6; // Drag your UI element for showing cost here
    public Button purchaseButton6; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText7; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText7; // Drag your UI element for showing cost here
    public Button purchaseButton7; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText8; // Drag your UI element for showing upgrade level here
    public TextMeshProUGUI upgradeCostText8; // Drag your UI element for showing cost here
    public Button purchaseButton8; // Drag the button here in the Inspector

    public TextMeshProUGUI upgradeText9;
    public TextMeshProUGUI upgradeCostText9;
    public Button purchaseButton9;

    public TextMeshProUGUI upgradeText10;
    public TextMeshProUGUI upgradeCostText10;
    public Button purchaseButton10;

    public TextMeshProUGUI upgradeText11;
    public TextMeshProUGUI upgradeCostText11;
    public Button purchaseButton11;

    public TextMeshProUGUI upgradeText12;
    public TextMeshProUGUI upgradeCostText12;
    public Button purchaseButton12;

    public TextMeshProUGUI upgradeText13;
    public TextMeshProUGUI upgradeCostText13;
    public Button purchaseButton13;

    public TextMeshProUGUI upgradeText14;
    public TextMeshProUGUI upgradeCostText14;
    public Button purchaseButton14;

    public TextMeshProUGUI upgradeText15;
    public TextMeshProUGUI upgradeCostText15;
    public Button purchaseButton15;

    public TextMeshProUGUI upgradeText16;
    public TextMeshProUGUI upgradeCostText16;
    public Button purchaseButton16;

    public TextMeshProUGUI upgradeText17;
    public TextMeshProUGUI upgradeCostText17;
    public Button purchaseButton17;

    public TextMeshProUGUI upgradeText18;
    public TextMeshProUGUI upgradeCostText18;
    public Button purchaseButton18;

    public TextMeshProUGUI upgradeText19;
    public TextMeshProUGUI upgradeCostText19;
    public Button purchaseButton19;

    public TextMeshProUGUI upgradeText20;
    public TextMeshProUGUI upgradeCostText20;
    public Button purchaseButton20;

    // exponent button1
    public TextMeshProUGUI exponentUpgrade1Text; // UI element for showing exponent upgrade level
    public TextMeshProUGUI exponentUpgrade1CostText; // UI element for showing exponent cost
    public Button exponent1PurchaseButton; // Button for purchasing the exponent upgrade
    public BigDouble exponentUpgradeLevel1 = 1; // Current level of the exponent upgrade
    public BigDouble exponentUpgradeCost1 = 1000f; // Initial cost of the exponent upgrade


    void Start()
    {
        purchaseButton.onClick.AddListener(BuyUpgrade);
        purchaseButton2.onClick.AddListener(BuyUpgrade2);
        purchaseButton3.onClick.AddListener(BuyUpgrade3);
        purchaseButton4.onClick.AddListener(BuyUpgrade4);
        purchaseButton5.onClick.AddListener(BuyUpgrade5);
        purchaseButton6.onClick.AddListener(BuyUpgrade6);
        purchaseButton7.onClick.AddListener(BuyUpgrade7);
        purchaseButton8.onClick.AddListener(BuyUpgrade8);
        purchaseButton9.onClick.AddListener(BuyUpgrade9);
        purchaseButton10.onClick.AddListener(BuyUpgrade10);
        purchaseButton11.onClick.AddListener(BuyUpgrade11);
        purchaseButton12.onClick.AddListener(BuyUpgrade12);
        purchaseButton13.onClick.AddListener(BuyUpgrade13);
        purchaseButton14.onClick.AddListener(BuyUpgrade14);
        purchaseButton15.onClick.AddListener(BuyUpgrade15);
        purchaseButton16.onClick.AddListener(BuyUpgrade16);
        purchaseButton17.onClick.AddListener(BuyUpgrade17);
        purchaseButton18.onClick.AddListener(BuyUpgrade18);
        purchaseButton19.onClick.AddListener(BuyUpgrade19);
        purchaseButton20.onClick.AddListener(BuyUpgrade20);
        exponent1PurchaseButton.onClick.AddListener(BuyExponentUpgrade1);
    }

    void Update()
    {
        // Check if it's time to add entropy passively
        if (Time.time >= nextEntropyGainTime &&
            (upgradeLevel > 0 ||
             upgradeLevel2 > 0 ||
             upgradeLevel3 > 0 ||
             upgradeLevel4 > 0 ||
             upgradeLevel5 > 0 ||
             upgradeLevel6 > 0 ||
             upgradeLevel7 > 0 ||
             upgradeLevel8 > 0 ||
             upgradeLevel9 > 0 ||
             upgradeLevel10 > 0 ||
             upgradeLevel11 > 0 ||
             upgradeLevel12 > 0 ||
             upgradeLevel13 > 0 ||
             upgradeLevel14 > 0 ||
             upgradeLevel15 > 0 ||
             upgradeLevel16 > 0 ||
             upgradeLevel17 > 0 ||
             upgradeLevel18 > 0 ||
             upgradeLevel19 > 0 ||
             upgradeLevel20 > 0))
        {
            upgradeLevel19 += entropyGainAmount * upgradeLevel20;
            upgradeLevel18 += entropyGainAmount * upgradeLevel19;
            upgradeLevel17 += entropyGainAmount * upgradeLevel18;
            upgradeLevel16 += entropyGainAmount * upgradeLevel17;
            upgradeLevel15 += entropyGainAmount * upgradeLevel16;
            upgradeLevel14 += entropyGainAmount * upgradeLevel15;
            upgradeLevel13 += entropyGainAmount * upgradeLevel14;
            upgradeLevel12 += entropyGainAmount * upgradeLevel13;
            upgradeLevel11 += entropyGainAmount * upgradeLevel12;
            upgradeLevel10 += entropyGainAmount * upgradeLevel11;
            upgradeLevel9 += entropyGainAmount * upgradeLevel10;
            upgradeLevel8 += entropyGainAmount * upgradeLevel9;
            upgradeLevel7 += entropyGainAmount * upgradeLevel8;
            upgradeLevel6 += entropyGainAmount * upgradeLevel7;
            upgradeLevel5 += entropyGainAmount * upgradeLevel6;
            upgradeLevel4 += entropyGainAmount * upgradeLevel5;
            upgradeLevel3 += entropyGainAmount * upgradeLevel4;
            upgradeLevel2 += entropyGainAmount * upgradeLevel3;
            upgradeLevel += entropyGainAmount * upgradeLevel2;
            gameManager.entropy += entropyGainAmount * upgradeLevel.Pow(exponentUpgradeLevel1);
            gameManager.UpdateUI(); // Update the UI to reflect new entropy
            UpdateUI();
            nextEntropyGainTime = Time.time + entropyGainInterval;
        }
    }


    void BuyUpgrade()
    {
        if (gameManager.entropy >= upgradeCost)
        {
            gameManager.entropy -= upgradeCost; // Deduct the cost
            upgradeLevel += 1; // Increment the upgrade level
            upgradeCost *= costMultiplier; // Increase the cost for the next level
            UpdateUI(); // Update the UI to reflect the new state
            gameManager.UpdateUI(); // Update the main game UI
        }
    }

    void BuyUpgrade2()
        {
            if (gameManager.entropy >= upgradeCost2)
            {
                gameManager.entropy -= upgradeCost2; // Deduct the cost
                upgradeLevel2 += 1; // Increment the upgrade level
                upgradeCost2 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade3()
        {
            if (gameManager.entropy >= upgradeCost3)
            {
                gameManager.entropy -= upgradeCost3; // Deduct the cost
                upgradeLevel3 += 1; // Increment the upgrade level
                upgradeCost3 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade4()
        {
            if (gameManager.entropy >= upgradeCost4)
            {
                gameManager.entropy -= upgradeCost4; // Deduct the cost
                upgradeLevel4 += 1; // Increment the upgrade level
                upgradeCost4 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade5()
        {
            if (gameManager.entropy >= upgradeCost5)
            {
                gameManager.entropy -= upgradeCost5; // Deduct the cost
                upgradeLevel5 += 1; // Increment the upgrade level
                upgradeCost5 *= costMultiplier; // Increase the cost for the next level
                UpdateUI(); // Update the UI to reflect the new state
                gameManager.UpdateUI(); // Update the main game UI
            }
        }

    void BuyUpgrade6()
    {
        if (gameManager.entropy >= upgradeCost6)
        {
            gameManager.entropy -= upgradeCost6;
            upgradeLevel6 += 1;
            upgradeCost6 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade7()
    {
        if (gameManager.entropy >= upgradeCost7)
        {
            gameManager.entropy -= upgradeCost7;
            upgradeLevel7 += 1;
            upgradeCost7 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade8()
    {
        if (gameManager.entropy >= upgradeCost8)
        {
            gameManager.entropy -= upgradeCost8;
            upgradeLevel8 += 1;
            upgradeCost8 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade9()
    {
        if (gameManager.entropy >= upgradeCost9)
        {
            gameManager.entropy -= upgradeCost9;
            upgradeLevel9 += 1;
            upgradeCost9 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade10()
    {
        if (gameManager.entropy >= upgradeCost10)
        {
            gameManager.entropy -= upgradeCost10;
            upgradeLevel10 += 1;
            upgradeCost10 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade11()
    {
        if (gameManager.entropy >= upgradeCost11)
        {
            gameManager.entropy -= upgradeCost11;
            upgradeLevel11 += 1;
            upgradeCost11 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade12()
    {
        if (gameManager.entropy >= upgradeCost12)
        {
            gameManager.entropy -= upgradeCost12;
            upgradeLevel12 += 1;
            upgradeCost12 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade13()
    {
        if (gameManager.entropy >= upgradeCost13)
        {
            gameManager.entropy -= upgradeCost13;
            upgradeLevel13 += 1;
            upgradeCost13 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade14()
    {
        if (gameManager.entropy >= upgradeCost14)
        {
            gameManager.entropy -= upgradeCost14;
            upgradeLevel14 += 1;
            upgradeCost14 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade15()
    {
        if (gameManager.entropy >= upgradeCost15)
        {
            gameManager.entropy -= upgradeCost15;
            upgradeLevel15 += 1;
            upgradeCost15 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade16()
    {
        if (gameManager.entropy >= upgradeCost16)
        {
            gameManager.entropy -= upgradeCost16;
            upgradeLevel16 += 1;
            upgradeCost16 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade17()
    {
        if (gameManager.entropy >= upgradeCost17)
        {
            gameManager.entropy -= upgradeCost17;
            upgradeLevel17 += 1;
            upgradeCost17 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade18()
    {
        if (gameManager.entropy >= upgradeCost18)
        {
            gameManager.entropy -= upgradeCost18;
            upgradeLevel18 += 1;
            upgradeCost18 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyUpgrade19()
    {
        if (gameManager.entropy >= upgradeCost19)
        {
            gameManager.entropy -= upgradeCost19;
            upgradeLevel19 += 1;
            upgradeCost19 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    public void BuyUpgrade20()
    {
        if (gameManager.entropy >= upgradeCost20)
        {
            gameManager.entropy -= upgradeCost20;
            upgradeLevel20 += 1;
            upgradeCost20 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }

    void BuyExponentUpgrade1()
    {
        if (gameManager.entropy >= exponentUpgradeCost1)
        {
            gameManager.entropy -= exponentUpgradeCost1;
            exponentUpgradeLevel1 += 1;
            exponentUpgradeCost1 *= costMultiplier;
            UpdateUI();
            gameManager.UpdateUI();
        }
    }


    public void UpdateUI()
    {
        string formattedUpgradeLevel = BigDoubleFormatter.FormatBigDouble(upgradeLevel);
        string formattedUpgradeCost = BigDoubleFormatter.FormatBigDouble(upgradeCost);
        upgradeText.text = $"{formattedUpgradeLevel}";
        upgradeCostText.text = $"{formattedUpgradeCost}λ";

        string formattedUpgradeLevel2 = BigDoubleFormatter.FormatBigDouble(upgradeLevel2);
        string formattedUpgradeCost2 = BigDoubleFormatter.FormatBigDouble(upgradeCost2);
        upgradeText2.text = $"{formattedUpgradeLevel2}";
        upgradeCostText2.text = $"{formattedUpgradeCost2}λ";

        string formattedUpgradeLevel3 = BigDoubleFormatter.FormatBigDouble(upgradeLevel3);
        string formattedUpgradeCost3 = BigDoubleFormatter.FormatBigDouble(upgradeCost3);
        upgradeText3.text = $"{formattedUpgradeLevel3}";
        upgradeCostText3.text = $"{formattedUpgradeCost3}λ";

        string formattedUpgradeLevel4 = BigDoubleFormatter.FormatBigDouble(upgradeLevel4);
        string formattedUpgradeCost4 = BigDoubleFormatter.FormatBigDouble(upgradeCost4);
        upgradeText4.text = $"{formattedUpgradeLevel4}";
        upgradeCostText4.text = $"{formattedUpgradeCost4}λ";

        string formattedUpgradeLevel5 = BigDoubleFormatter.FormatBigDouble(upgradeLevel5);
        string formattedUpgradeCost5 = BigDoubleFormatter.FormatBigDouble(upgradeCost5);
        upgradeText5.text = $"{formattedUpgradeLevel5}";
        upgradeCostText5.text = $"{formattedUpgradeCost5}λ";

        string formattedUpgradeLevel6 = BigDoubleFormatter.FormatBigDouble(upgradeLevel6);
        string formattedUpgradeCost6 = BigDoubleFormatter.FormatBigDouble(upgradeCost6);
        upgradeText6.text = $"{formattedUpgradeLevel6}";
        upgradeCostText6.text = $"{formattedUpgradeCost6}λ";

        string formattedUpgradeLevel7 = BigDoubleFormatter.FormatBigDouble(upgradeLevel7);
        string formattedUpgradeCost7 = BigDoubleFormatter.FormatBigDouble(upgradeCost7);
        upgradeText7.text = $"{formattedUpgradeLevel7}";
        upgradeCostText7.text = $"{formattedUpgradeCost7}λ";

        string formattedUpgradeLevel8 = BigDoubleFormatter.FormatBigDouble(upgradeLevel8);
        string formattedUpgradeCost8 = BigDoubleFormatter.FormatBigDouble(upgradeCost8);
        upgradeText8.text = $"{formattedUpgradeLevel8}";
        upgradeCostText8.text = $"{formattedUpgradeCost8}λ";

        string formattedUpgradeLevel9 = BigDoubleFormatter.FormatBigDouble(upgradeLevel9);
        string formattedUpgradeCost9 = BigDoubleFormatter.FormatBigDouble(upgradeCost9);
        upgradeText9.text = $"{formattedUpgradeLevel9}";
        upgradeCostText9.text = $"{formattedUpgradeCost9}λ";

        string formattedUpgradeLevel10 = BigDoubleFormatter.FormatBigDouble(upgradeLevel10);
        string formattedUpgradeCost10 = BigDoubleFormatter.FormatBigDouble(upgradeCost10);
        upgradeText10.text = $"{formattedUpgradeLevel10}";
        upgradeCostText10.text = $"{formattedUpgradeCost10}λ";

        string formattedUpgradeLevel11 = BigDoubleFormatter.FormatBigDouble(upgradeLevel11);
        string formattedUpgradeCost11 = BigDoubleFormatter.FormatBigDouble(upgradeCost11);
        upgradeText11.text = $"{formattedUpgradeLevel11}";
        upgradeCostText11.text = $"{formattedUpgradeCost11}λ";

        string formattedUpgradeLevel12 = BigDoubleFormatter.FormatBigDouble(upgradeLevel12);
        string formattedUpgradeCost12 = BigDoubleFormatter.FormatBigDouble(upgradeCost12);
        upgradeText12.text = $"{formattedUpgradeLevel12}";
        upgradeCostText12.text = $"{formattedUpgradeCost12}λ";

        string formattedUpgradeLevel13 = BigDoubleFormatter.FormatBigDouble(upgradeLevel13);
        string formattedUpgradeCost13 = BigDoubleFormatter.FormatBigDouble(upgradeCost13);
        upgradeText13.text = $"{formattedUpgradeLevel13}";
        upgradeCostText13.text = $"{formattedUpgradeCost13}λ";

        string formattedUpgradeLevel14 = BigDoubleFormatter.FormatBigDouble(upgradeLevel14);
        string formattedUpgradeCost14 = BigDoubleFormatter.FormatBigDouble(upgradeCost14);
        upgradeText14.text = $"{formattedUpgradeLevel14}";
        upgradeCostText14.text = $"{formattedUpgradeCost14}λ";

        string formattedUpgradeLevel15 = BigDoubleFormatter.FormatBigDouble(upgradeLevel15);
        string formattedUpgradeCost15 = BigDoubleFormatter.FormatBigDouble(upgradeCost15);
        upgradeText15.text = $"{formattedUpgradeLevel15}";
        upgradeCostText15.text = $"{formattedUpgradeCost15}λ";

        string formattedUpgradeLevel16 = BigDoubleFormatter.FormatBigDouble(upgradeLevel16);
        string formattedUpgradeCost16 = BigDoubleFormatter.FormatBigDouble(upgradeCost16);
        upgradeText16.text = $"{formattedUpgradeLevel16}";
        upgradeCostText16.text = $"{formattedUpgradeCost16}λ";

        string formattedUpgradeLevel17 = BigDoubleFormatter.FormatBigDouble(upgradeLevel17);
        string formattedUpgradeCost17 = BigDoubleFormatter.FormatBigDouble(upgradeCost17);
        upgradeText17.text = $"{formattedUpgradeLevel17}";
        upgradeCostText17.text = $"{formattedUpgradeCost17}λ";

        string formattedUpgradeLevel18 = BigDoubleFormatter.FormatBigDouble(upgradeLevel18);
        string formattedUpgradeCost18 = BigDoubleFormatter.FormatBigDouble(upgradeCost18);
        upgradeText18.text = $"{formattedUpgradeLevel18}";
        upgradeCostText18.text = $"{formattedUpgradeCost18}λ";

        string formattedUpgradeLevel19 = BigDoubleFormatter.FormatBigDouble(upgradeLevel19);
        string formattedUpgradeCost19 = BigDoubleFormatter.FormatBigDouble(upgradeCost19);
        upgradeText19.text = $"{formattedUpgradeLevel19}";
        upgradeCostText19.text = $"{formattedUpgradeCost19}λ";

        string formattedUpgradeLevel20 = BigDoubleFormatter.FormatBigDouble(upgradeLevel20);
        string formattedUpgradeCost20 = BigDoubleFormatter.FormatBigDouble(upgradeCost20);
        upgradeText20.text = $"{formattedUpgradeLevel20}";
        upgradeCostText20.text = $"{formattedUpgradeCost20}λ";

        string formattedexponentUpgradeLevel1 = BigDoubleFormatter.FormatBigDouble(exponentUpgradeLevel1);
        exponentUpgrade1Text.text = $"^{formattedexponentUpgradeLevel1}";
        string formattedexponentUpgradeCost1 = BigDoubleFormatter.FormatBigDouble(exponentUpgradeCost1);
        exponentUpgrade1CostText.text = $"{formattedexponentUpgradeCost1}λ";
    }
}
