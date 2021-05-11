using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string gameSceneName;
    public string aboutScene;
    public AudioClip bgm;
    public AudioSource myaudio;


    // Start is called before the first frame update
    void Start()
    {
        myaudio = GetComponent<AudioSource>();
        myaudio.clip = bgm;
        myaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);  //Loads the game scene 
        Debug.Log("Start!");

    }

    public void ContinueGame()
    {
        //SceneManager.LoadScene(gameSceneName);
    }

    public void AboutGame()
    {
        SceneManager.LoadScene(aboutScene);
        Debug.Log("About");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
