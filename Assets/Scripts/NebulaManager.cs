using TMPro;
using UnityEngine;
using UnityEngine.UI;
using BreakInfinity;

public class NebulaManager : MonoBehaviour
{
    public GameManager gameManager;
    public PassiveUpgrade passiveUpgrade;
    public BigDouble NBConvertPrice = 1000f;
    public BigDouble NebulaPoints = 0f;
    public Button NBConvertButton;

    public Button NB1UpgradeButton;

    public TextMeshProUGUI NebulaPointsText;
    public TextMeshProUGUI NBConvertPriceText;



    void Start()
    {
        NBConvertButton.onClick.AddListener(NBConvert);
        NB1UpgradeButton.onClick.AddListener(BuyNB1);
    }

    void NBConvert()
        {
            if (gameManager.entropy >= NBConvertPrice)
            {
                gameManager.entropy -= NBConvertPrice;
                NebulaPoints += 1;
                NBConvertPrice *= NBConvertPrice;
                UpdateUI();
                gameManager.UpdateUI();
            }
        }

    void BuyNB1()
        {
            if (NebulaPoints >= 1)
            {
                NebulaPoints -= 1;
                passiveUpgrade.entropyGainInterval /= 2f;
                UpdateUI();
            }
        }

    void UpdateUI()
    {
        string formattedNebulaPoints = BigDoubleFormatter.FormatBigDouble(NebulaPoints);
        string formattedNBConvertPrice = BigDoubleFormatter.FormatBigDouble(NBConvertPrice);
        NebulaPointsText.text = $"{formattedNebulaPoints} NP";
        NBConvertPriceText.text = $"Convert {formattedNBConvertPrice} λ to 1 NB";
    }
}