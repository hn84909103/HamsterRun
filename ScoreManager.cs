using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public int maxScore;
    public Text scoreText;
    public bool AllCollected = false;
    public GameObject arrow1;
    public GameObject arrow2;

    void Start()
    {
        score = 0;
        //Debug.Log("score:" + score);
    }

    void Update()
    {
        scoreText.text = score.ToString();
        IsAllCollected(score);
    }


    public static void receiveScore()
    {
        score += 1;
        Debug.Log("point:" + score);
    }

    public void IsAllCollected(int currentScore)
    {

        if (currentScore == maxScore)
        {
            AllCollected = true;
            arrow1.SetActive(false);
            arrow2.SetActive(true);
            //Debug.Log("Collected all!");
        }
        else
        {
            arrow1.SetActive(true);
        }
    }


}
