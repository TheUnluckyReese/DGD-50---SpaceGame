using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    public float gameTimer, gameTimeOver;
    public int gameScore;
    public int highScore;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("High Score", 0).ToString();
    }
    void Update()
    {
        
        gameScore ++;
        gameTimer -= Time.deltaTime ;
        DisplayTime(gameTimer);

        PlayerPrefs.SetInt("HighScore", gameScore);

        //timerText.text = ("Time  " + gameTimer);
        scoreText.text = gameScore.ToString();
        


        
        if(gameTimer <= gameTimeOver)
        {
            SceneManager.LoadScene("gameOver");

        }

        // /string timerText = string.Format("0:00");
    }

    void DisplayTime(float gameTimer)
    {
        
        
        float minutes = Mathf.FloorToInt(gameTimer / 60); 
        float seconds = Mathf.FloorToInt(gameTimer % 60);

        timerText.text = string.Format("{0:00}:{1:00}" , minutes , seconds);
    }

    
}
