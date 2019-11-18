using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedLantern : MonoBehaviour
{
    public Text diolouge;
    public Text name1;
    public bool isTalking = false;
    public GameObject canvas;
    public bool test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPickup.hasLantern)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {

        if (!isTalking && !PlayerPickup.hasLantern)
        {
            isTalking = true;
            name1.text = PlayerPrefs.GetString("Playername") + ":";

            int num = Random.Range(0, 2);
            if (num == 0)
            {
                diolouge.text = "It looks dark in there. I need a light.";
            }
            canvas.SetActive(true);
            if (num == 1)
            {
                diolouge.text = "I can't do my job without any light to see with.";
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
