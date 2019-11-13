using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Severs : MonoBehaviour
{
    public GameObject server1;
    public GameObject server2;
    public GameObject server3;
    public GameObject server4;
    public GameObject server5;
    public GameObject server6;
    public static bool serverIsOn =  false;
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
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && Generatro.generatorIsOn)
        {
            Destroy(server1);
            Destroy(server2);
            Destroy(server3);
            Destroy(server4);
            Destroy(server5);
            Destroy(server6);
            serverIsOn = true;
        }
    }
}
