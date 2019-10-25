using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider HealthBar;
    private void Start()
    {
        healthText.text = "HP: " + health;
        HealthBar.maxValue = health;
        HealthBar.value = health;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            healthText.text = "HP: " + health;
            HealthBar.value = health;
            if (health < 1)
            {
                SceneManager.LoadScene("gameover");
            }
        }
        else if (collision.gameObject.tag == "health")
        {
            health = health + 1;
            healthText.text = "HP: " + health;
            HealthBar.value = health;
            
        }
    }
    public void Update()
    {
        if (health > 6)
        {
            health = 6;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health = health - 1;
            healthText.text = "HP: " + health;
            HealthBar.value = health;
            if (health < 1)
            {
                SceneManager.LoadScene("gameover");
            }
        }
    }
}
