using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public float gameTimer;
    public int gameScore;
    public int highScore;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;



    void Update()
    {
        gameTimer += Time.deltaTime;
        gameScore ++;

        timerText.text = ("Time  " + gameTimer);
        scoreText.text = ("Score " + gameScore);
        highScoreText.text = ("High Score" + highScore ) ;
    }
}
