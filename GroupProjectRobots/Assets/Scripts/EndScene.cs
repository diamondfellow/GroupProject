using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public float timer = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ComputerSpeakHP.Dead && timer > -1)
        {
            timer -= Time.deltaTime;
            if(timer <=0)
            {
                SceneManager.LoadScene("DeadTown");
            }
        }
    }
}
