using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mavis : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public static bool Quest = false;
    public GameObject canvas;
    public bool test;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.E) && !isTalking && collision.gameObject.tag == "Player")
        {
            isTalking = true;
            canvas.SetActive(true);
            name1.text = "Mavis";

            if (isTalking == true)
            {
                diolouge.text = "Good morning " + PlayerPrefs.GetString("Playername" + "!") + " I need a favor… Sylvia recently shared with me that she knows a way to end the robots. To liberate the world. I trust you, MC, more than anyone in town. You’re the only one with the wit and strength to save us. Talk to Sylvia, find out what you need to do, and save us.";

                Quest = true;
            }
        }
        else if (Quest == true && Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player")
        {
            
            diolouge.text = "Go now! Sylvia needs to see you!";
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