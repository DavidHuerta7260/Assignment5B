using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // allows easy access from other scripts
    public Text scoreText; // UI Text that displays the score
    private int score = 0;

    void Awake()
    {
        // Make this script globally accessible
        instance = this;
    }

    // Adds 1 point and updates the UI
    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    // Optional: get the current score for win screen
    public int GetScore()
    {
        return score;
    }
}

