using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Max : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public bool tPose = false;
    public GameObject canvas;
    

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && !isTalking)
        {
            isTalking = true;
            Time.timeScale = 0;
            name1.text = "Max";
            canvas.SetActive(true);
            int num = Random.Range(0, 3);
            if (num == 0)
            {
                diolouge.text = "Hi " + PlayerPrefs.GetString("Playername") + "!";
            }
            if (num == 1)
            {
                diolouge.text = "Hey if you see Taran ask him about my on-brand sandwich cookies.";
            }
            if (num == 2)
            {
                diolouge.text = "it robit time";
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
