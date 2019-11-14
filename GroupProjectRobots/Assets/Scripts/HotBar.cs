using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotBar : MonoBehaviour
{
    public GameObject lantern;
    public GameObject lantern1;
    public GameObject lantern2;
    public GameObject lantern3;
    public GameObject bandage;
    public GameObject bandage1;
    public GameObject bandage2;
    public GameObject bandage3;
    public GameObject keycard;
    public GameObject keycard1;
    public GameObject keycard2;
    public GameObject keycard3;
    public GameObject crowbar;
    public GameObject crowbar1;
    public GameObject crowbar2;
    public GameObject crowbar3;
    public GameObject metalpipe;
    public GameObject metalpipe1;
    public GameObject metalpipe2;
    public GameObject metalpipe3;
    public GameObject robotarm;
    public GameObject robotarm1;
    public GameObject robotarm2;
    public GameObject robotarm3;
    public bool inventory1 = false;
    public bool inventory2 = false;
    public bool inventory3 = false;
    public bool inventory4 = false;
    public static bool inventoryfull = false;
    public int inventorycounter = 0;
    public static string inventoryitem1;
    public static string inventoryitem2;
    public static string inventoryitem3;
    public static string inventoryitem4;
    public Transform player;
    public GameObject Keycard;
    public GameObject Bandage;
    public GameObject Crowbar;
    public GameObject Lantern;




    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetString("inventory1"))
        {
            case "lantern":
                LanternPickup();
                break;
            case "bandage":
                BandagePickup();
                break;
            case "keycard":
                KeycardPickup();
                break;
            case "crowbar":
                CrowbarPickup();
                break;

        }
        switch (PlayerPrefs.GetString("inventory2"))
        {
            case "lantern":
                LanternPickup();
                break;
            case "bandage":
                BandagePickup();
                break;
            case "keycard":
                KeycardPickup();
                break;
            case "crowbar":
                CrowbarPickup();
                break;
        }
        switch (PlayerPrefs.GetString("inventory3"))
        {
            case "lantern":
                LanternPickup();
                break;
            case "bandage":
                BandagePickup();
                break;
            case "keycard":
                KeycardPickup();
                break;
            case "crowbar":
                CrowbarPickup();
                break;
        }
        switch (PlayerPrefs.GetString("inventory4"))
        {
            case "lantern":
                LanternPickup();
                break;
            case "bandage":
                BandagePickup();
                break;
            case "keycard":
                KeycardPickup();
                break;
            case "crowbar":
                CrowbarPickup();
                break;

        }
    } 
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1) && inventory1)
        {
            UseItem1();
        }
        if (Input.GetKeyUp(KeyCode.Alpha2) && inventory2)
        {
            UseItem2();
        }
        if (Input.GetKeyUp(KeyCode.Alpha3) && inventory3)
        {
            UseItem3();
        }
        if (Input.GetKeyUp(KeyCode.Alpha4) && inventory4)
        {
            UseItem4();
        }

        if (inventorycounter == 4)
        {
            inventoryfull = true;
        }
        else
        {
            inventoryfull = false;
        }
    }
    public void  LanternPickup()
    {
        if (!inventory1)
        {

            lantern.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "lantern";
            PlayerPrefs.SetString("inventory1", "lantern");
        }
        else if (!inventory2)
        {
            lantern1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "lantern";
            PlayerPrefs.SetString("inventory2", "lantern");
        }
        else if (!inventory3)
        {
            lantern2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "lantern";
            PlayerPrefs.SetString("inventory3", "lantern");

        }
        else if (!inventory4)
        {
            lantern3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "lantern";
            PlayerPrefs.SetString("inventory4", "lantern");
        }

    }
    public void BandagePickup()
    {
        if (!inventory1)
        {
            bandage.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "bandage";
            PlayerPrefs.SetString("inventory1", "bandage");
        }
        else if (!inventory2)
        {
            bandage.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "bandage";
            PlayerPrefs.SetString("inventory2", "bandage");
        }
        else if (!inventory3)
        {
            bandage1.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "bandage";
            PlayerPrefs.SetString("inventory3", "bandage");
        }
        else if (!inventory4)
        {
            bandage3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "bandage";
            PlayerPrefs.SetString("inventory4", "bandage");
        }
    }
    public void CrowbarPickup()
    {
        if (!inventory1)
        {
            crowbar.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "crowbar";
            PlayerPrefs.SetString("inventory1", "crowbar");
        }
        else if (!inventory2)
        {
            crowbar1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "crowbar";
            PlayerPrefs.SetString("inventory2", "crowbar");
        }
        else if (!inventory3)
        {
            crowbar2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "crowbar";
            PlayerPrefs.SetString("inventory3", "crowbar");
        }
        else if (!inventory4)
        {
            crowbar3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "crowbar";
            PlayerPrefs.SetString("inventory4", "crowbar");
            
        }
    }
    public void KeycardPickup()
    {
        if (!inventory1)
        {
            keycard.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "keycard";
            PlayerPrefs.SetString("inventory1", "keycard");
        }
        else if (!inventory2)
        {
            keycard1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "keycard";
            PlayerPrefs.SetString("inventory2", "keycard");
        }
        else if (!inventory3)
        {
            keycard2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "keycard";
            PlayerPrefs.SetString("inventory3", "keycard");
        }
        else if (!inventory4)
        {
            keycard3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "keycard";
            PlayerPrefs.SetString("inventory4", "keycard");
        }
    }
    public void MetalPipePickup()
    {
        if (!inventory1)
        {
            metalpipe.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "metalpipe";
        }
        else if (!inventory2)
        {
            metalpipe1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "metalpipe";
        }
        else if (!inventory3)
        {
            metalpipe2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "metalpipe";
        }
        else if (!inventory4)
        {
            metalpipe3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "metalpipe";
        }
    }
    public void RobotArmPickup()
    {
        if (!inventory1)
        {
            robotarm.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "robotarm";
        }
        else if (!inventory2)
        {
            robotarm1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "robotarm";
        }
        else if (!inventory3)
        {
            robotarm2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "robotarm";
        }
        else if (!inventory4)
        {
            robotarm3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "robotarm";
        }
    }
    public void Hotbar1()
    {
        switch (inventoryitem1)
        {
            case "lantern":
                lantern.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(Lantern, player.position, player.rotation);
                break;
            case "bandage":
                bandage.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(Bandage, player.position, player.rotation);
                break;
            case "keycard":
                keycard.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(Keycard, player.position, player.rotation);
                break;
            case "crowbar":
                crowbar.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
            case "metalpipe":
                metalpipe.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
        }
 
    }
    public void Hotbar2()
    {
        switch (inventoryitem2)
        {
            case "lantern":
                lantern1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(Lantern, player.position, player.rotation);
                break;
            case "bandage":
                bandage1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(Bandage, player.position, player.rotation);
                break;
            case "keycard":
                keycard1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(Keycard, player.position, player.rotation);
                break;
            case "crowbar":
                crowbar1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
            case "metalpipe":
                metalpipe1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
        }
    }
    public void Hotbar3()
    {
        switch (inventoryitem3)
        {
            case "lantern":
                lantern2.SetActive(false);
                inventory3 = false;
                inventorycounter -= 1;
                Instantiate(Lantern, player.position, player.rotation);
                break;
            case "bandage":
                bandage2.SetActive(false);
                inventory3 = false;
                inventorycounter -= 1;
                Instantiate(Bandage, player.position, player.rotation);
                break;
            case "keycard":
                keycard2.SetActive(false);
                inventory3 = false;
                inventorycounter -= 1;
                Instantiate(Keycard, player.position, player.rotation);
                break;
            case "crowbar":
                crowbar2.SetActive(false);
                inventory3 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
            case "metalpipe":
                metalpipe2.SetActive(false);
                inventory3 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
        }
    }
    public void Hotbar4()
    {
        switch (inventoryitem4)
        {
            case "lantern":
                lantern3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(Lantern, player.position, player.rotation);
                break;
            case "bandage":
                bandage3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(Bandage, player.position, player.rotation);
                break;
            case "keycard":
                keycard3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(Keycard, player.position, player.rotation);
                break;
            case "crowbar":
                crowbar3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
            case "metalpipe":
                metalpipe3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(Crowbar, player.position, player.rotation);
                break;
        }
    }
    public void UseItem1()
    {
        if (inventoryitem1 == "bandage")
        {
            PlayerHP.health = 6;
        } 
    }
    public void UseItem2()
    {
        if (inventoryitem2 == "bandage")
        {
            PlayerHP.health = 6;
        }
    }
    public void UseItem3()
    {
        if (inventoryitem3 == "bandage")
        {
            PlayerHP.health = 6;
        }

    }
    public void UseItem4()
    {
        if (inventoryitem4 == "bandage")
        {
            PlayerHP.health = 6;
        }
    }
}



