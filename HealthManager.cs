using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public Slider slider;

    public float maxHealth = 100;
    public float currentHealth;

    public GameObject player;
    public GameObject enemy;
   // public GameObject enemy2;

    public string gameOverScene;

    void Start()
    {
        slider.maxValue = maxHealth;
        currentHealth = maxHealth;
    }

    void Update()
    {
        LoseHealth();

        if (currentHealth <= 0)
        {
            player.SetActive(false);
            enemy.SetActive(false);
            //enemy2.SetActive(false);
            SceneManager.LoadScene(gameOverScene);
        }
    }
    /*
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        Debug.Log("receive max");
    }*/

    void LoseHealth()
    {
        currentHealth -= 0.004f /* 50 / 180sec*60 */;
        SetHealth(currentHealth);
    }

    public void Damage(int d)
    {
        currentHealth -= d;
        SetHealth(currentHealth);
    }

    public void AddHP()
    {
        currentHealth += 10f;
        SetHealth(currentHealth);
        Debug.Log("HP+1");
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        Debug.Log("receive current");
    }
}
