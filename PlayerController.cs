using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public bool isOnTheGround = true;

    public HealthManager healthManager;
    public ScoreManager scoreManager;
    public LevelControl levelControl;

    public static int levelId = 1;

    public bool IsCollected;

    public string MenuScene;

    public GameObject pauseScreen;

    public AudioClip bgm;
    public AudioSource myaudio;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;

        myaudio = GetComponent<AudioSource>();
        myaudio.clip = bgm;
        myaudio.Play();
    }

    void Update()
    {

        float xDirection = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //forward backward
        float yDirection = Input.GetAxis("Vertical") *  speed * Time.deltaTime; //left right

        transform.Translate(xDirection, 0, yDirection);
        
       // Debug.Log(xDirection + ", " + yDirection);


        if (Input.GetButtonDown("Jump") && isOnTheGround)  //jump
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            isOnTheGround = false;
            Debug.Log("level ID: " + levelId);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            PauseGame();     
        }

        IsCollected = scoreManager.AllCollected;

    }

   
    public void OnCollisionEnter(Collision collision)
    {   //aviod double jump
        if (collision.gameObject.tag == "Ground")
        {
            isOnTheGround = true;
        }

        //encounter enemy
        if (collision.gameObject.tag == "Enemy")
        {
            healthManager.Damage(30);
            Debug.Log("Enemy");
        }

        //unlock next level
        if (collision.gameObject.tag == "Cage")
        {
            levelControl.Unlock(IsCollected);
            Debug.Log("Check condition");
        }

        //teleport
        if (collision.gameObject.tag == "teleport")
        {
            transform.position = new Vector3(48.8f, 139.4f, 158.6f);
            
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
        Debug.Log("pause");
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("resume");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(MenuScene);
    }

}
