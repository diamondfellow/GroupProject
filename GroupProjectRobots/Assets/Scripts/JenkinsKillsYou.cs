using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class JenkinsKillsYou : MonoBehaviour
{
    public static int health = 6;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jenkins")
        {
            health = health - 6;
            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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