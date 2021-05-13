using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager:MonoBehaviour
{
    public Text highScoreText1, highScoreText2, highScoreText3, highScoreText4, highScoreText5;
    private void Start()
    {
        highScoreText1.text = "1.High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        highScoreText2.text = "2.High Score: " + PlayerPrefs.GetInt("HighScore2", 0).ToString();
        highScoreText3.text = "3.High Score: " + PlayerPrefs.GetInt("HighScore3", 0).ToString();
        highScoreText4.text = "4.High Score: " + PlayerPrefs.GetInt("HighScore4", 0).ToString();
        highScoreText5.text = "5.High Score: " + PlayerPrefs.GetInt("HighScore5", 0).ToString();
    }

    public static void UpdateHighScores(int score)
    {
        int temp1, temp2, temp3, temp4;
        if (score >= PlayerPrefs.GetInt("HighScore", 0))
        {
            temp1 = PlayerPrefs.GetInt("HighScore", 0);
            PlayerPrefs.SetInt("HighScore", score);

            temp2 = PlayerPrefs.GetInt("HighScore2", 0);
            PlayerPrefs.SetInt("HighScore2", temp1);

            temp3 = PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("HighScore3", temp2);

            temp4 = PlayerPrefs.GetInt("HighScore4", 0);
            PlayerPrefs.SetInt("HighScore4", temp3);

            PlayerPrefs.SetInt("HighScore5", temp4);
            return;
        }
        if (score <= PlayerPrefs.GetInt("HighScore", 0) && score > PlayerPrefs.GetInt("HighScore2", 0))
        {
            temp2 = PlayerPrefs.GetInt("HighScore2", 0);
            PlayerPrefs.SetInt("HighScore2", score);

            temp3 = PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("HighScore3", temp2);

            temp4 = PlayerPrefs.GetInt("HighScore4", 0);
            PlayerPrefs.SetInt("HighScore4", temp3);

            PlayerPrefs.SetInt("HighScore5", temp4);
            return;
        }
        if (score <= PlayerPrefs.GetInt("HighScore2", 0) && score > PlayerPrefs.GetInt("HighScore3", 0))
        {
            temp3 = PlayerPrefs.GetInt("HighScore3", 0);
            PlayerPrefs.SetInt("HighScore3", score);

            temp4 = PlayerPrefs.GetInt("HighScore4", 0);
            PlayerPrefs.SetInt("HighScore4", temp3);

            PlayerPrefs.SetInt("HighScore5", temp4);
            return;
        }
        if (score <= PlayerPrefs.GetInt("HighScore3", 0) && score > PlayerPrefs.GetInt("HighScore4", 0))
        {
            temp4 = PlayerPrefs.GetInt("HighScore4", 0);
            PlayerPrefs.SetInt("HighScore4", score);

            PlayerPrefs.SetInt("HighScore5", temp4);
            return;
        }
        if (score <= PlayerPrefs.GetInt("HighScore4", 0) && score > PlayerPrefs.GetInt("HighScore5", 0))
        {
            PlayerPrefs.SetInt("HighScore5", score);
            return;
        }
    }
}
