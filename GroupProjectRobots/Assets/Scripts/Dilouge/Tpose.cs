using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tpose : MonoBehaviour

{
    public Text diolouge;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyUp(KeyCode.T))
        {
            canvas.SetActive(false);
            diolouge.text = "";



        }
    }
}
