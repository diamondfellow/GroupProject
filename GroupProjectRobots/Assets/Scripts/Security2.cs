using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Security2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject door;
    public static bool Panel = false;
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
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && Generatro.generatorIsOn && Severs.serverIsOn)
        {
            Destroy(panel);
            Destroy(door);
            Panel = true;
        }
    }
}
