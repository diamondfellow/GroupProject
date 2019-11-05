﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceLight : MonoBehaviour
{
    public GameObject lights;
     void OnTriggerExit2D(Collider2D collision)
     {
        Color c = GetComponent<SpriteRenderer>().color;
        c.a = 1;
        GetComponent<SpriteRenderer>().color = c;
        lights.SetActive(true);
     }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Color c = GetComponent<SpriteRenderer>().color;
        c.a = 0;
        GetComponent<SpriteRenderer>().color = c;
        lights.SetActive(false);
    }

}
