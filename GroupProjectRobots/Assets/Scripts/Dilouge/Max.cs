﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Max : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public GameObject canvas;
    public bool test;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            isTalking = true;
            name1.text = "Max";

            int num = Random.Range(0, 3);
            if (num == 0)
            {
                diolouge.text = "Hi " + PlayerPrefs.GetString("Playername" + "!");
            }
            if (num == 1)
            {
                diolouge.text = "Hey if you see Taran ask him about my on-brand sandwich cookies.";
            }
            canvas.SetActive(true);
            if (num == 2)
            {
                diolouge.text = "It robit time!";
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