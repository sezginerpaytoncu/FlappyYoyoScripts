using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    private int highScore;

    public Text ScoreText;
    public GameObject deathScreen;

    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }
    public void GameOver()
    {
        if(score >= PlayerPrefs.GetInt("HighScore", 0))
            ScoreText.text = "New High Score!\nScore: " + score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore5", 0))
            HighScoreManager.UpdateHighScores(score);

        Time.timeScale = 0;
        deathScreen.SetActive(true);
    }

}
