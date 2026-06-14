using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // <-- CRUCIAL: Lets the script talk to TextMeshPro!

public class GameManager : MonoBehaviour
{
    // Keeping track of stats
    public int currentPatience = 5;
    public int itemsCollected = 0;
    public int targetItems = 13;

    // --- UI ELEMENTS ---
    [Header("UI Text Fields")]
    public TextMeshProUGUI itemText;      // Drag your Item Text here
    public TextMeshProUGUI patienceText;  // Drag your Patience Text here
    public TextMeshProUGUI statusText;    // Drag a "Status/Win/Lose" Text here (Optional)

    // Check if the player has visited the register after collecting 13 items
    private bool canWin = false;

    void Start()
    {
        Debug.Log("Shift Started! Collect 13 items and avoid customers.");
        UpdateUI();
        
        if (statusText != null) 
        {
            statusText.text = "Shift Started! Collect 13 items.";
        }
    }

    // Called by items when the player picks them up
    public void CollectItem()
    {
        itemsCollected++;
        Debug.Log("Items Collected: " + itemsCollected + "/13");
        UpdateUI(); // Refresh the numbers on screen

        if (itemsCollected >= targetItems)
        {
            canWin = true;
            Debug.Log("All items collected! Head back to the Cashier Counter to finish your shift!");
            
            if (statusText != null)
            {
                statusText.text = "All items collected! Head to the Cashier Counter!";
            }
        }
    }

    // Called by customers when the player enters their vicinity
    public void LosePatience(int damage)
    {
        currentPatience -= damage;
        Debug.Log("Patience remaining: " + currentPatience);
        UpdateUI(); // Refresh the numbers on screen

        if (currentPatience <= 0)
        {
            GameOver();
        }
    }

    // Called when the player interacts with the Cashier Counter
    public void CheckWinCondition()
    {
        if (canWin)
        {
            Debug.Log("YOU WIN! Shift complete, clocking out!");
            
            if (statusText != null)
            {
                statusText.text = "YOU WIN! Shift complete!";
            }
        }
        else
        {
            Debug.Log("You haven't collected 13 items yet! Keep cleaning!");
            
            if (statusText != null)
            {
                statusText.text = "Keep cleaning! Need 13 items.";
            }
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER! You lost your patience and lost your job!");
        
        if (statusText != null)
        {
            statusText.text = "GAME OVER! You lost your job!";
        }

        Time.timeScale = 0f; // Freezes the game logic
    }

    // This brand new function automatically rewrites the visual HUD text elements
    void UpdateUI()
    {
        if (itemText != null)
        {
            itemText.text = "Items: " + itemsCollected + " / " + targetItems;
        }

        if (patienceText != null)
        {
            patienceText.text = "Patience: " + currentPatience;
        }
    }
}