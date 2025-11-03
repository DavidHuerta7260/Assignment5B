/*
* David Huerta
* 3D Prototype
* Tracks and displays the player’s score when targets are destroyed.
*/
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    public Text scoreText; 
    private int score = 0;

    void Awake()
    {
        
        instance = this;
    }

    
    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

   
    public int GetScore()
    {
        return score;
    }
}

