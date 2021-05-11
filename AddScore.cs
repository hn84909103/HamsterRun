using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddScore : MonoBehaviour
{
    
    public GameObject seed;
    public AudioClip pointEffect;
    public AudioSource myaudio;

    private void Start()
    {
        myaudio = GetComponent<AudioSource>();
    }

    //if player collided the seed
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playMusic();
            ScoreManager.receiveScore();
            seed.SetActive(false);
        }
    }
    public void playMusic()
    {
        myaudio.clip = pointEffect;
        myaudio.Play();
        Debug.Log("Play");
    }
}
