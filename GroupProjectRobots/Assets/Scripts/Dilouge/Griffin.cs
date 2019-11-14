using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Griffin : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public GameObject canvas;
    public bool tpose = false;
    public bool hi = false;
 
     void OnTriggerStay2D(Collider2D collision)
     {

        if (Input.GetKeyDown(KeyCode.E))
        {
            isTalking = true;
            name1.text = "Griffin:";
            
            if (Input.GetKeyDown(KeyCode.E) && hi == false)
            {
               diolouge.text = "Hey there " + PlayerPrefs.GetString("Playername") + "!";
                hi = true;
                canvas.SetActive(true);
            }
            else if(Input.GetKeyDown(KeyCode.E) && hi == true)
            {
                diolouge.text = "Press T to T-pose";
                tpose = true;
                canvas.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            canvas.SetActive(true);
            diolouge.text = "You fool. You absolute buffoon." +
                " You think you can challenge me in my own realm?" +
                " You think you can rebel against my authority?" +
                " You dare come into my house and upturn my dining chairs and spill coffee grounds in my fancy coffee machine?" +
                " You thought you were safe in your chain mail armor behind that screen of yours. " +
                " I will take these laminate wood floor boards and destroy you." +
                " I didn’t want war." +
                " But I didn’t start it.";
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
