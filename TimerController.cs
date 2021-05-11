using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public float timeRemaining = 300;
    public GameObject player;
    public GameObject enemy;
    public Text timeText;

    public static float recordOne = 0;
    public static float recordTow = 0;
    public static float recordThree = 0;

    public bool r1 = false;
    public bool r2 = false;
   

    public string gameOverScene;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timer starts");
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime(timeRemaining);
        //LoseHealth();
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time's up");
            player.SetActive(false);
            enemy.SetActive(false);
            timeRemaining = 0;
            SceneManager.LoadScene(gameOverScene);
        }
    }

    void DisplayTime(float t)
    {
        float minutes = Mathf.FloorToInt(t / 60);
        float seconds = Mathf.FloorToInt(t % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public static void SaveRecord(float t)
    {

        switch (PlayerController.levelId)
        {
            case 1:
                recordOne = t;
                Debug.Log("**** level 1:" + recordOne);
                break;

            case 2:
                recordTow = t;
                Debug.Log("**** level 2:" + recordTow);
                break;

            case 3:
                recordThree = t;
                Debug.Log("**** level 3:" + recordThree);
                break;
        }
    }
}
