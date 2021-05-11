using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader2 : MonoBehaviour
{
    public bool flag = false;
    float loadTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel()
    {
        //anaimae
        PlayerController.levelId = 3;
        Debug.Log("level ID: " + PlayerController.levelId);
        //wait
        yield return new WaitForSeconds(loadTime);

        //load scene
        SceneManager.LoadScene("Level3");
    }
}
