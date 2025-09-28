using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager Instance { get; private set; }

    public int Score = 0;
    public TextMeshProUGUI scoreText; // Optional: Assign a UI Text (from Canvas) to show score


    void Start()
    {
        scoreText.text = "Score: " + Score.ToString();
    }
    private void Awake()
    {
        // Ensure only one instance exists
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int points)
    {
        Score += points;
        
    }

    private void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Score;
        }
    }
    
    
}
