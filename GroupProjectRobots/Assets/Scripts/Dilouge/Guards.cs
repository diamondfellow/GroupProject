using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guards : MonoBehaviour
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
            name1.text = "Guard:";


            if (isTalking = true && Sylvia.LeaveTown == false)
            {
                diolouge.text = "Hey, Mavis was looking for you.";

                canvas.SetActive(true);
            }

            else if (isTalking = true && Sylvia.LeaveTown == true)
            {
                diolouge.text = "You should see the doctor before you leave";
                canvas.SetActive(true);
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