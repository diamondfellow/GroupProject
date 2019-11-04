using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Taran : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public bool tPose = false;
    public GameObject canvas;
    public string l;
    
    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTalking)
        {
            isTalking = true;
            Time.timeScale = 0;
            name1.text = "Taran";
            canvas.SetActive(true);
            int num = Random.Range(0, 3);
            if (num == 0)
            {
                diolouge.text = "Sup " + PlayerPrefs.GetString("Playername") + "!";
            }
            if (num == 1)
            {
                diolouge.text = "Hey " + PlayerPrefs.GetString("Playername") + " I’m working on Mavis’ generator, if you notice anything weird with the power let me know.";
            }
            if (num == 2)
            {
                diolouge.text = "sup bro we out of on-brand sandwich cookies again";
            }
            if (Input.GetKeyDown(KeyCode.E) && isTalking)
            {
                canvas.SetActive(false);
                Time.timeScale = 1;
                isTalking = false;
                name1.text = "";
            }


        } 
    }
}
