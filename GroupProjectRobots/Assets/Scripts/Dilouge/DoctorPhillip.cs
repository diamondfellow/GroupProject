using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoctorPhillip : MonoBehaviour
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
            name1.text = "Doctor Phillip:";

            int num = Random.Range(0, 3);
            if (num == 0)
            {
                diolouge.text = "Hello " + PlayerPrefs.GetString("Playername") + "!" + " It’s so good to see you. You never swing by the clinic anymore, what’s up with that? Swing by more often, I want to see you!";
            }
            if (num == 1)
            {
                diolouge.text = PlayerPrefs.GetString("Playername") + "!" + " it’s so great to see your lovely face. You should really come by more, an old man gets lonely you know?";
            }
            canvas.SetActive(true);
            if (num == 2)
            {
                diolouge.text = "Try not to die!";
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