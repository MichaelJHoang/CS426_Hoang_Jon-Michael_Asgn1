using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 5;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void AddPoint()
    {
        if (score != maxScore)
        {
            score++;
            scoreText.text = "Score: " + score;
        }
        else if (score >= maxScore)
            scoreText.text = "You won!";
    }
}