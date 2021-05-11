using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadRecoed : MonoBehaviour
{
    public TimerController timerController;
    public Text t1;
    public Text t2;
    public Text t3;

    public AudioClip bgm;
    public AudioSource myaudio;

    // Start is called before the first frame update
    void Start()
    {
        DisplayTime(300f - TimerController.recordOne, t1);
        DisplayTime(300f - TimerController.recordTow, t2);
        DisplayTime(300f - TimerController.recordThree, t3);

        myaudio = GetComponent<AudioSource>();
        myaudio.clip = bgm;
        myaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DisplayTime(float t, Text am)
    {
        float minutes = Mathf.FloorToInt(t / 60);
        float seconds = Mathf.FloorToInt(t % 60);

        am.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
    
