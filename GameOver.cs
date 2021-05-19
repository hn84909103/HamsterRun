using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string gameSceneName;
    public string level1SceneName;
    public string level2SceneName;
    public string level3SceneName;
   // public static int level=1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    public void Replay()
    {
        switch (PlayerController.levelId)
        {
            case 1:
                SceneManager.LoadScene(level1SceneName);
                break;

            case 2:
                SceneManager.LoadScene(level2SceneName);
                break;

            case 3:
                SceneManager.LoadScene(level3SceneName);
                break;
        }
    }
}
