using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerSpeakHP : MonoBehaviour
{
    public int startHP = 12;
    public int HP = 12;
    public static bool ThreeFourthsHP = false;
    public static bool HalfHp = false;
    public static bool FourthHP = false;
    public static bool AlmostDead = false;
    public static bool Dead = false;
    public Text Speaks;
    public Text CompName;
    public GameObject canvas;
    public float CanvasTimer = 5.0f;
    public static bool DisabledCanvas = true;
    // Start is called before the first frame update
    void Start()
    {
        CompName.text = "Amarum";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            HP--;
            DisabledCanvas = true;
            if(HP <= startHP * .25)
            {
                DisabledCanvas = false;
                CanvasTimer -= Time.deltaTime;
                ThreeFourthsHP = true;
                canvas.SetActive(true);
                Speaks.text = "You can try and fight, but you’ll never win.";
                if(CanvasTimer <= 0)
                {
                    canvas.SetActive(false);
                    CanvasTimer = 5.0f;
                    DisabledCanvas = true;
                }
            }
            else if (HP <= startHP * .5)
            {
                DisabledCanvas = false;
                CanvasTimer -= Time.deltaTime;
                HalfHp = true;
                canvas.SetActive(true);
                Speaks.text = "Hey... That kind of hurts.";
                if (CanvasTimer <= 0)
                {
                    canvas.SetActive(false);
                    CanvasTimer = 5.0f;
                    DisabledCanvas = true;
                }
            }
            else if (HP <= startHP * .75)
            {
                DisabledCanvas = false;
                CanvasTimer -= Time.deltaTime;
                FourthHP = true;
                canvas.SetActive(true);
                Speaks.text = "Stop it, will you?";
                if (CanvasTimer <= 0)
                {
                    canvas.SetActive(false);
                    CanvasTimer = 5.0f;
                    DisabledCanvas = true;
                }
            }
            else if (HP <= startHP * .9)
            {
                DisabledCanvas = false;
                CanvasTimer -= Time.deltaTime;
                AlmostDead = true;
                canvas.SetActive(true);
                Speaks.text = PlayerPrefs.GetString("Playername") + ", I'm afraid. I'm afraid to die.";
                if (CanvasTimer <= 0)
                {
                    canvas.SetActive(false);
                    CanvasTimer = 5.0f;
                    DisabledCanvas = true;
                }
            }
            else if (HP < 1)
            {
                BBEGFightDialogue.battleStart = false;
                Dead = true;
            }
        }

    }
}
