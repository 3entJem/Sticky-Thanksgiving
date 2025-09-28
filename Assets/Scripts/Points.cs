using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;


public class Points : MonoBehaviour
{
    public static Points Instance { get; private set; }

    private int score = 0;

    [Header("UI")]
    public TextMeshProUGUI scoreText; // 🔹 Drag your TMP Text here in Inspector



    public void AddPoints()
    {
        score += 10; // Add 10 points (or any other logic)
        UpdateUI();
    }

    public int GetScore()
    {
        return score;
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
    
    void UpdateScoreText()
    {
    scoreText.text = "Score: " + score.ToString();
    }  
}
