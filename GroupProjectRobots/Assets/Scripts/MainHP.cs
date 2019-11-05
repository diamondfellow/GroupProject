using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainHP : MonoBehaviour
{
    public static int health = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            if (health < 1)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
