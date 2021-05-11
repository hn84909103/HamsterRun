using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{

    public string mainMenuScene;
    

    public void ReturnM()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
