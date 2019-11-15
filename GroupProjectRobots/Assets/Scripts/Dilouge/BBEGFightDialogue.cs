﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BBEGFightDialogue : MonoBehaviour
{
    public Text compName;
    public Text Speaking;
    public static bool awake = false;
    public static bool speak1 = true;
    public static bool speak2 = false;
    public static bool speak3 = false;
    public static bool speak4 = false;
    public static bool speak5 = false;
    public static bool speak6 = false;
    public static bool speak7 = false;
    public static bool speak8 = false;
    public static bool speak9 = false;
    public GameObject canvas;
    public bool isTalking = false;
    public static bool battleStart = false;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);
        compName.text = "???";
        Speaking.text = "...";
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (speak1)
        {
            Speaking.text = "... Hello?";
            awake = true;
            speak1 = false;
            speak2 = true;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTalking)
        {
            isTalking = true;
            if (speak2)
            {
                awake = false;
                isTalking = true;
                Speaking.text = "My name is Amarum. It’s been so long since I’ve had friends. Are we... Are we friends?";
                speak2 = false;
                speak3 = true;
                isTalking = false;
            }
            else if (speak3)
            {
                isTalking = true;
                compName.text = "Amarum";
                Speaking.text = "It feels so good to have friends again. Wait, why did you... Why are you here?";
                speak3 = false;
                speak4 = true;
                isTalking = false;
            }
            else if (speak4)
            {
                isTalking = true;
                Speaking.text = "...";
                speak4 = false;
                speak5 = true;
                isTalking = false;
            }
            else if (speak5)
            {
                isTalking = true;
                Speaking.text = "Oh.";
                speak5 = false;
                speak6 = true;
                isTalking = false;
            }
            else if (speak6)
            {
                isTalking = true;
                Speaking.text = "You’re here to kill me.";
                speak6 = false;
                speak7 = true;
                isTalking = false;
            }
            else if (speak7)
            {
                isTalking = true;
                Speaking.text = "... You want me to just give it to you? To give you the secret?";
                speak7 = false;
                speak8 = true;
                isTalking = false;
            }
            else if (speak8)
            {
                isTalking = true;
                Speaking.text = "Well, " + PlayerPrefs.GetString("Playername");
                speak8 = false;
                speak9 = true;
                isTalking = false;
            }
            else if (speak9)
            {
                isTalking = true;
                Speaking.text = "I’m afraid I can’t do that.";
                speak9 = false;
                isTalking = false;
            }
            else
            {
                battleStart = true;
                canvas.SetActive(false);
            }
        }
    }
}
