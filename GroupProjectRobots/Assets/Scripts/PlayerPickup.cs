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
    public static bool hasLantern = false;
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
        if(collision.gameObject.tag == "lantern" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.LanternPickup();
        }
        if (collision.gameObject.tag == "crowbar" && Input.GetKeyDown(KeyCode.E))
        {
            hotbar.CrowbarPickup();
            Destroy(collision.gameObject);
            hasCrowbar = true;
            EnemyHP.damage = 1;
        }
        if (collision.gameObject.tag == "bandage" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            hotbar.BandagePickup();
        }
        if (collision.gameObject.tag == "keycard" && Input.GetKeyDown(KeyCode.E))
        {
            hotbar.KeycardPickup();
            Destroy(collision.gameObject);
            hasKeycard = true;
        }

        if (collision.gameObject.tag == "metalPipe" && Input.GetKeyDown(KeyCode.E))
        {
            hotbar.MetalPipePickup();
            Destroy(collision.gameObject);
            hasMetalPipe = true;
            EnemyHP.damage = 2;
        }
        if (collision.gameObject.tag == "robotArm" && Input.GetKeyDown(KeyCode.E))
        {
            hotbar.RobotArmPickup();
            Destroy(collision.gameObject);
            hasRobotArm = true;
            EnemyHP.damage = 3;
        }



    }
}
