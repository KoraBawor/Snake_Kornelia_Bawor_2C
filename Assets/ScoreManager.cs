using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake(){
        instance = this;
    }

    void Start()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "POINTS: " + score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "POINTS: " + score.ToString();
        if (score > highscore){
          PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void ResetState()
    {
        score = 0;
        scoreText.text = "POINTS: " + score.ToString();
    }
}
