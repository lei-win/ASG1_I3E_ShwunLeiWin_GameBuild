using UnityEngine;

public class CashierCounter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object walking up to the counter is the Player
        if (other.CompareTag("Player"))
        {
            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                // Tell the GameManager to check if we hit the 15-item goal
                manager.CheckWinCondition();
            }
        }
    }
}