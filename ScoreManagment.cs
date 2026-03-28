using UnityEngine;
using UnityEngine.UI;

public class ScoreManagment : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        UpdateScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "score: " + score;
    }
}