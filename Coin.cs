using UnityEngine;

// This script handles what happens when the player touches a coin
public class Coin : MonoBehaviour
{
    // Called when another collider enters this trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the object that touched the coin is the player
        if (collision.CompareTag("Player"))
        {
            // Try to get the PlayerController component from the player
            PlayerController playerController = collision.GetComponent<PlayerController>();

            // If the player has a PlayerController component
            if (playerController != null)
            {
                // Destroy the coin (collect it)
                Destroy(gameObject);
            }
        }
    }
}
