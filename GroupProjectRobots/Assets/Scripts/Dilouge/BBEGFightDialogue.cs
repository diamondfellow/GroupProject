using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BBEGFightDialogue : MonoBehaviour
{
    public Text compName;
    public Text Speaking;
    static bool speak1 = true;
    bool speak2 = false;
    bool speak3 = false;
    static bool speak4 = false;
    bool speak5 = false;
    static bool speak6 = false;
    bool speak7 = false;
    bool speak8 = false;
    static bool speak9 = false;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        compName.text = "???";
        Speaking.text = "...";
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (speak1)
            {
                Speaking.text = "... Hello?";
                speak1 = false;
                speak2 = true;
            }
            else if (speak2)
            {
                Speaking.text = "My name is Amarum. It’s been so long since I’ve had friends. Are we... Are we friends?";
                speak2 = false;
                speak3 = true;
            }
            else if (speak3)
            {
                compName.text = "Amarum";
                Speaking.text = "It feels so good to have friends again. Wait, why did you... Why are you here?";
                speak3 = false;
                speak4 = true;
            }
            else if (speak4)
            {
                Speaking.text = "...";
                speak4 = false;
                speak5 = true;
            }
            else if (speak5)
            {
                Speaking.text = "Oh.";
                speak5 = false;
                speak6 = true;
            }
            else if (speak6)
            {
                Speaking.text = "You’re here to kill me.";
                speak6 = false;
                speak7 = true;
            }
            else if (speak7)
            {
                Speaking.text = "... You want me to just give it to you? To give you the secret?";
                speak7 = false;
                speak8 = true;
            }
            else if (speak8)
            {
                Speaking.text = "Well, " + PlayerPrefs.GetString("Playername");
                speak8 = false;
                speak9 = true;
            }
            else if (speak9)
            {
                Speaking.text = "I’m afraid I can’t do that.";
                speak9 = false;
            }
            else
            {
                canvas.SetActive(false);
            }
        }
    }
}
