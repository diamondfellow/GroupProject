using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Start is called before the first frame update
    void Start()
    {
        heart1.GetComponent<Animator>().SetFloat("hp", 1);
        heart2.GetComponent<Animator>().SetFloat("hp", 1);
        heart3.GetComponent<Animator>().SetFloat("hp", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHP.health == 6)
        {
            heart1.SetActive(true);
            heart1.GetComponent<Animator>().SetFloat("hp", 1);
            heart2.SetActive(true);
        }
        else if (PlayerHP.health == 5)
        {
            heart1.SetActive(true);
            heart1.GetComponent<Animator>().SetFloat("hp", 0);
            heart2.SetActive(true);
        }
        else if (PlayerHP.health == 4)
        {
            heart2.SetActive(true);
            heart2.GetComponent<Animator>().SetFloat("hp", 1);
            heart1.SetActive(false);

        }
        else if (PlayerHP.health == 3)
        {
            heart2.SetActive(true);
            heart2.GetComponent<Animator>().SetFloat("hp", 0);
            heart1.SetActive(false);
        }
        else if (PlayerHP.health == 2)
        {
            heart2.SetActive(false);
            heart1.SetActive(false);
            heart3.GetComponent<Animator>().SetFloat("hp", 1);
            
        }
        else if (PlayerHP.health == 1)
        {
            heart2.SetActive(false);
            heart1.SetActive(false);
            heart3.GetComponent<Animator>().SetFloat("hp", 0);

        }
        else if (PlayerHP.health == 0)
        {
            heart2.SetActive(false);
            heart1.SetActive(false);
            heart3.SetActive(false);

        }


    }
}
