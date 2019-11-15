using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("WakeUp", BBEGFightDialogue.awake);
        GetComponent<Animator>().SetBool("Friendly", BBEGFightDialogue.speak3);
        GetComponent<Animator>().SetBool("Realization", BBEGFightDialogue.speak4);
        GetComponent<Animator>().SetBool("Angry",BBEGFightDialogue.speak5);
        GetComponent<Animator>().SetBool("AngrySpeak",BBEGFightDialogue.speak6);
        GetComponent<Animator>().SetBool("CrazyMad",BBEGFightDialogue.battleStart);
    }
}
