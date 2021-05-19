using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public bool flag = false;
    float loadTime = 2f;

    void Start()
    {
        flag = true;
    }

    void Update()
    {
        if (flag)
        {
            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel()
    {
        PlayerController.levelId = 2;
        //wait
        yield return new WaitForSeconds(loadTime);

        //load scene
        SceneManager.LoadScene("Level2");
    }
}
