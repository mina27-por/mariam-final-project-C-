using UnityEngine;
using UnityEngine.UI;

public class ScoreManagment : MonoBehaviour
// This script manages the player's score and updates the UI text
{
    public Text scoreText;
     // Reference to the UI Text component that displays the score
    public int score = 0;
     // Stores the current score (starts at 0)

    void Start()
    {
        UpdateScore(); // Initialize the score display
    }

    public void AddScore(int amount) //is used to add points to the score
    {
        score += amount;
        // Increase the score by the given amount
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "score: " + score; // Display the score in the UI Text
    }
}
