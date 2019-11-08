using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sylvia : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public bool Quest = false;
    public GameObject canvas;
    public bool test;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.E) && Mavis.Quest == false)
        {
            isTalking = true;
            canvas.SetActive(true);
            name1.text = "Sylvia";

            if (isTalking == true)
            {
                diolouge.text = "Morning  " + PlayerPrefs.GetString("Playername" + "!") + " I heard Mavis was looking for you ... Oh! Sorry, I was thinking about something. ";

                
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && Mavis.Quest == true)
        {

            diolouge.text = "Oh… Mavis told you about that? It’s pretty dangerous, I don’t know… But if you really think you can do it, I need something from the old factory EAST of town. There’s a… piece. A bit of machinery that I can use to shut down every robot in the world, manually. The robots there are probably rusted through by now but… Listen, if you want to try, I’m not going to stop you. But please, be safe. I don’t want any more blood on my hands. ";
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