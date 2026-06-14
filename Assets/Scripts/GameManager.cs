using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Keeping track of stats
    public int currentPatience = 5;
    public int itemsCollected = 0;
    public int targetItems = 13;

    // Check if the player has visited the register after collecting 13 items
    private bool canWin = false;

    void Start()
    {
        Debug.Log("Shift Started! Collect 13 items and avoid customers.");
    }

    // Called by items when the player picks them up
    public void CollectItem()
    {
        itemsCollected++;
        Debug.Log("Items Collected: " + itemsCollected + "/13");

        if (itemsCollected >= targetItems)
        {
            canWin = true;
            Debug.Log("All items collected! Head back to the Cashier Counter to finish your shift!");
        }
    }

    // Called by customers when the player enters their vicinity
    public void LosePatience(int damage)
    {
        currentPatience -= damage;
        Debug.Log("Patience remaining: " + currentPatience);

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
            
        }
        else
        {
            Debug.Log("You haven't collected 13 items yet! Keep cleaning!");
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER! You lost your patience and lost your job!");
        Time.timeScale = 0f; // Freezes the game logic
    }
}