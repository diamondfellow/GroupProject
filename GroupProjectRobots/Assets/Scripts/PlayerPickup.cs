using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public HotBar hotbar;
    public static bool hasCrowbar = false;
    public static bool hasMetalPipe = false;
    public static bool hasRobotArm = false;
    public static bool hasKeycard = false;
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
        if(collision.gameObject.tag == "Crowbar" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hasCrowbar = true;
        }
        if (collision.gameObject.tag == "Crowbar" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hasCrowbar = true;
            EnemyHP.damage = 1;
        }
        if (collision.gameObject.tag == "metalPipe" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hasMetalPipe = true;
            EnemyHP.damage = 2;
        }
        if (collision.gameObject.tag == "robotArm" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hasRobotArm = true;
            EnemyHP.damage = 3;
        }
        if (collision.gameObject.tag == "keycard" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hasKeycard = true;
            
        }


    }
}
