using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taran : MonoBehaviour
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
            name1.text = "Taran:";

            int num = Random.Range(0, 3);
            if (num == 0)
            {
                diolouge.text = "Sup " + PlayerPrefs.GetString("Playername") + "!";
            }
            if (num == 1)
            {
                diolouge.text = "I’m working on Mavis’ generator, if you notice anything weird with the power let me know.";
            }
            canvas.SetActive(true);
            if (num == 2)
            {
                diolouge.text = "Sup bro we out of on-brand sandwich cookies again.";
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
