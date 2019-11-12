using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheresNoGoingBack : MonoBehaviour
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
            name1.text = PlayerPrefs.GetString("Playername") + ":";

            int num = Random.Range(0, 2);
            if (num == 0)
            {
                diolouge.text = "I know im scared but iv'e got to be brave, for my town!";
            }
            canvas.SetActive(true);
            if (num == 1)
            {
                diolouge.text = "I can't go back now i have a job to do!";
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