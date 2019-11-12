using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject scanner;
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
         if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            Destroy(door);
            Destroy(scanner);


        } 
    }
}
