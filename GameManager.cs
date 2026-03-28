using UnityEngine;
using UnityEngine.UI; // Required for Legacy Text

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [Header("UI Reference")]
    public Text scoreText; // Make sure this says 'Text', not 'TMP_Text'

    private int score = 0;

    void Awake()
    {
        // Singleton pattern so you can call this from any script
        if (instance == null) {
            instance = this;
        }
    }

    void Start()
    {
        UpdateScoreUI();
    }

    // Call this from other scripts: ScoreManager.instance.AddScore(10);
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogWarning("Score Text reference is missing in the Inspector!");
        }
    }
}