using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jenkins : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public GameObject canvas;
    public bool test;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (!isTalking)
        {
            isTalking = true;
            name1.text = "Jenkins:";

            int num = Random.Range(0, 2);
            if (num == 0)
            {
                diolouge.text = "GET OFF MY LAWN!";
            }
            canvas.SetActive(true);
            if (num == 1)
            {
                diolouge.text = "GET OFF MY LAWN!";
            }
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        canvas.SetActive(false);
        diolouge.text = "";
        name1.text = "";
        isTalking = false;


    }
}
