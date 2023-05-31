using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public TextMeshProUGUI score;
    public TextMeshProUGUI GameOverscore;

    int highScore;
    public GameObject newHighScore;
    public TextMeshProUGUI highScoreText;


    void Update()
    {
        score.text = "Score: " + scoreValue.ToString();

        GameOverscore.text = "Score: " + scoreValue.ToString();

        highScore = PlayerPrefs.GetInt("HighScore", highScore);

        if (scoreValue > highScore)
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
            newHighScore.SetActive(true);
        }
        else
        {
            newHighScore.SetActive(false);
        }

        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
