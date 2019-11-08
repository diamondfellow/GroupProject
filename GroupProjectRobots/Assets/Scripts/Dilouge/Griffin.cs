using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Griffin : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public bool tPose = false;
    public GameObject canvas;
    public bool test;
 
     void OnTriggerStay2D(Collider2D collision)
     {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("OOG");
            isTalking = true;
            //Time.timeScale = 0;
            name1.text = "Griffin";
            
            int num = Random.Range(0, 2);
            if (num == 0)
            {
               diolouge.text = "Hey there " + PlayerPrefs.GetString("Playername" + "!");
            }
            if(num == 1)
            {
                diolouge.text = "Press T to T-pose";
                tPose = true;
            }
            canvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.T) && tPose)
            {
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
        
     }
    public void OnTriggerExit2D(Collider2D collision)
    {
        canvas.SetActive(false);
        diolouge.text = "";
        name1.text = "";
        isTalking = false;


    }
}
