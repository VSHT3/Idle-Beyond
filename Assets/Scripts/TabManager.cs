using UnityEngine;
using UnityEngine.EventSystems;


public class TabManager : MonoBehaviour
{
    public GameObject EntropyPanel;
    public GameObject AchievementsPanel;
    public GameObject StartPanel;
    public GameObject AchButton;

    public GameObject EntropyButton;
    public GameObject EntropyButtons;
    public GameObject EntropyClickButton;
    public GameObject EntropyClickPanel;
    public GameObject EntropyGenButton;
    public GameObject EntropyGenPanel;

    public GameObject AutomationTab;
    public GameObject AutomationTabButton;

    void Start()
    {
        StartPanel.SetActive(true);
        EntropyPanel.SetActive(false);
        AchievementsPanel.SetActive(false);
        AchButton.SetActive(false);

        EntropyButton.SetActive(false);
        EntropyButtons.SetActive(false);
        EntropyClickButton.SetActive(false);
        EntropyGenPanel.SetActive(false);
        EntropyClickPanel.SetActive(false);
        EntropyGenButton.SetActive(false);

        AutomationTab.SetActive(false);
        AutomationTabButton.SetActive(false);
    }

    public void ShowStart()
    {
        StartPanel.SetActive(false);
        EntropyPanel.SetActive(true);
        EntropyClickPanel.SetActive(true);
    }

    public void ShowEntropy()
    {
        EntropyPanel.SetActive(true);
        AchievementsPanel.SetActive(false);
        AutomationTab.SetActive(false);
    }

    public void ShowAchievements()
    {
        EntropyPanel.SetActive(false);
        AutomationTab.SetActive(false);
        AchievementsPanel.SetActive(true);
    }

    public void UnlockAchievements()
    {
        AchButton.SetActive(true);
    }

    public void UnlockAutomation()
    {
        AutomationTabButton.SetActive(true);
    }

    public void ShowEntropyHover()
    {
        // Show buttons when hovering over EntropyButton
        EntropyClickButton.SetActive(true);
        EntropyGenButton.SetActive(true);
    }

    public void HideEntropyHover()
    {
        // Hide buttons when not hovering
        EntropyClickButton.SetActive(false);
        EntropyGenButton.SetActive(false);
    }

    public void ShowEntropyClick()
    {
        EntropyGenPanel.SetActive(false);
        AchievementsPanel.SetActive(false);
        EntropyPanel.SetActive(true);
        EntropyClickPanel.SetActive(true);
        AutomationTab.SetActive(false);
    }


    public void ShowEntropyGen()
    {
        AchievementsPanel.SetActive(false);
        EntropyPanel.SetActive(true);
        EntropyClickPanel.SetActive(false);
        EntropyGenPanel.SetActive(true);
        AutomationTab.SetActive(false);
    }

        public void ShowAutomation()
        {
            AchievementsPanel.SetActive(false);
            EntropyPanel.SetActive(true);
            EntropyPanel.SetActive(false);
            AutomationTab.SetActive(true);
        }
}
