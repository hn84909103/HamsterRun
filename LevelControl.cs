﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public string LevelTScene;
    public string Level2TScene;
    public string Win;
    public TimerController timercontroller;

    //public ScoreManager scoreManager;

    public void Unlock(bool b)
    {
        if (b)
        {
            //save record
            TimerController.SaveRecord(timercontroller.timeRemaining);
            checkLevel();
        }

        /* GameOver.level = 2;
         SceneManager.LoadScene(LevelTScene);*/

        else
        {
            Debug.Log("no");
        }
    }

    public void checkLevel() {
        switch (PlayerController.levelId)
        {
            case 1:
                GameOver.level = 2;
                SceneManager.LoadScene(LevelTScene);
                break;

            case 2:
                GameOver.level = 3;
                SceneManager.LoadScene(Level2TScene);
                break;

            case 3:
                SceneManager.LoadScene(Win);
                break;
        }
    }
    /*
    IEnumerator LoadLevel()
    {
        //anaimae

        //wait
        yield return new WaitForSeconds(2f);

        //load scene
        SceneManager.LoadScene("Level2");
    }*/
}
