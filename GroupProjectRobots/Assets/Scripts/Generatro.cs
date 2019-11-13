using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatro : MonoBehaviour
{
    public static bool generatorIsOn = false;
    public GameObject dark;
    public GameObject door;
    public GameObject monitor1;
    public GameObject monitor2;
    public GameObject monitor3;
    public GameObject monitor4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            Destroy(dark);
            Destroy(door);
            Destroy(monitor1);
            Destroy(monitor2);
            Destroy(monitor3);
            Destroy(monitor4);
            generatorIsOn = true;

        }
    }
}
