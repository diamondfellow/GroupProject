using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceLight : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        Color c =GetComponent<SpriteRenderer>().color;
        c.a = 0;
        GetComponent<SpriteRenderer>().color = c;
    }
}
