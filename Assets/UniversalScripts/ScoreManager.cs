using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public TMP_Text scoreText;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    public void MinusScore(int amount)
    {
        score -= amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = " " + score;
    }
}
