using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public HotBar hotbar;
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
        if(collision.gameObject.tag == "Purple" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.PurplePickup();
        }
        if (collision.gameObject.tag == "Green" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.GreenPickup();
        }
        if (collision.gameObject.tag == "Blue" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.BluePickup();
        }
        if (collision.gameObject.tag == "Yellow" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.YellowPickup();
        }
    }
}
