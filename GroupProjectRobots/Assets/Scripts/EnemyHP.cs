using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    public int health = 10;
    public static int damage = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health -= damage; 

            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
    //void
}
