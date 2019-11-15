using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerHPAnimVariables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("Smug",ComputerSpeakHP.ThreeFourthsHP);
        GetComponent<Animator>().SetBool("Hurt",ComputerSpeakHP.HalfHp);
        GetComponent<Animator>().SetBool("Plea", ComputerSpeakHP.FourthHP);
        GetComponent<Animator>().SetBool("LastWords", ComputerSpeakHP.AlmostDead);
        GetComponent<Animator>().SetBool("Break", ComputerSpeakHP.Dead);
        GetComponent<Animator>().SetBool("Still", ComputerSpeakHP.DisabledCanvas);
    }
}
