﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public int health = 6;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            if (health < 1)
            {
                    SceneManager.LoadScene("gameover");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health = health - 1;
            if (health < 1)
            {
                    SceneManager.LoadScene("gameover");
            }

        }
    }
    public void Update()
    {
        if (health > 6)
        {
            health = 6;
        }
    }
}