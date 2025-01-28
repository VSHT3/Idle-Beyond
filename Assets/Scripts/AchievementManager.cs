using TMPro;
using UnityEngine;
using UnityEngine.UI; // Required for UI elements
using System.Collections; // Required for Coroutine

public class AchievementManager : MonoBehaviour
{
    public GameManager gameManager;// Reference to the GameManager
    public TabManager tabManager; // Reference to the TabManager
    public AudioSource unlockSound; // Reference to the sound of unlocking an Achievement
    public TextMeshProUGUI popup;
    public PassiveUpgrade passiveUpgrade;

    // Boolean to track if the achievement has been unlocked
    private bool achievement1Unlocked = false;
    private bool achievement2Unlocked = false;
    private bool achievement3Unlocked = false;
    private bool achievement4Unlocked = false;

    public Button achievementsTabButton; // for ach2
    public TextMeshProUGUI achievement2Text; //text to change color
    public TextMeshProUGUI achievement3Text; //text to change color
    public TextMeshProUGUI achievement4Text; //text to change color

    void Start()
    {
        achievementsTabButton.onClick.AddListener(CheckAchievement2); // Listener for the button
    }

    void Update()
    {
        // Check if the achievement has already been unlocked
        if (!achievement1Unlocked)
        {
            // Check if the entropy value has reached 10
            if (gameManager.entropy >= 10)
            {
                // Unlock the achievement
                UnlockAchievement1();
            }
        }

        // Check if the achievement has already been unlocked
        if (!achievement3Unlocked)
        {
            // Check if the entropy value has reached 10
            if (gameManager.entropy >= 100)
            {
                // Unlock the achievement
                UnlockAchievement3();
            }
        }

        // Check if the achievement has already been unlocked
        if (!achievement4Unlocked)
        {
            // Check if the entropy value has reached 10
            if (passiveUpgrade.upgradeLevel20 >= 1)
            {
                // Unlock the achievement
                UnlockAchievement4();
            }
        }
    }

    private void UnlockAchievement1()
    {
        // Call the method to unlock achievements in TabManager
        tabManager.UnlockAchievements();

        // Set the achievementUnlocked to true to prevent re-triggering
        achievement1Unlocked = true;

        StartCoroutine(ShowPopup("Madness begins: Reach 10λ!"));

        // Play the sound
        unlockSound.Play();
    }

    private void UnlockAchievement3()
    {
        // Set the achievementUnlocked to true to prevent re-triggering
        achievement3Unlocked = true;

        StartCoroutine(ShowPopup("Madness..? MADNESS!: Reach 100λ!"));

        achievement3Text.color = Color.green;

        // Play the sound
        unlockSound.Play();
    }

    private void CheckAchievement2()
    {
        // Ensure the achievement isn't already unlocked
        if (!achievement2Unlocked)
        {
            // Unlock achievement2
            UnlockAchievement2();
        }
    }

    private void UnlockAchievement4()
    {
        // Set the achievementUnlocked to true to prevent re-triggering
        achievement4Unlocked = true;
        StartCoroutine(ShowPopup("Serious exponential growth!"));
        achievement4Text.color = Color.green;
        tabManager.UnlockAutomation();
        unlockSound.Play();
    }

    private void UnlockAchievement2()
    {
        // Call the method to unlock achievements in TabManager
        tabManager.EntropyButtons.SetActive(true);
        tabManager.EntropyButton.SetActive(true);

        achievement2Text.color = Color.green;
        // Set the achievement2Unlocked to true to prevent re-triggering
        achievement2Unlocked = true;

        StartCoroutine(ShowPopup("Button Clicked: Achievement unlocked!"));

        // Play the sound
        unlockSound.Play();
    }


    private IEnumerator ShowPopup(string message)

    {
        // Set the message and make it visible
        popup.text = message;

        popup.gameObject.SetActive(true);

        // Wait for a few seconds
        yield return new WaitForSeconds(5f);

        // Hide the message
        popup.gameObject.SetActive(false);
    }


}