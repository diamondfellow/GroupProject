using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotBar : MonoBehaviour
{
    public GameObject Purple;
    public GameObject Purple1;
    public GameObject Purple2;
    public GameObject Purple3;
    public GameObject Blue;
    public GameObject Blue1;
    public GameObject Blue2;
    public GameObject Blue3;
    public GameObject Yellow;
    public GameObject Yellow1;
    public GameObject Yellow2;
    public GameObject Yellow3;
    public GameObject Green;
    public GameObject Green1;
    public GameObject Green2;
    public GameObject Green3;
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
    public GameObject yellow1;
    public GameObject blue1;
    public GameObject green1;
    public GameObject purple1;
    



    // Start is called before the first frame update
    void Start()
    {

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
    public void PurplePickup()
    {
        if (!inventory1)
        {

            Purple.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "purple";
        }
        else if (!inventory2)
        {
            Purple1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "purple";
        }
        else if (!inventory3)
        {
            Purple2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "purple";
        }
        else if (!inventory4)
        {
            Purple3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "purple";
        }

    }
    public void BluePickup()
    {
        if (!inventory1)
        {
            Blue.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "blue";
        }
        else if (!inventory2)
        {
            Blue1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "blue";
        }
        else if (!inventory3)
        {
            Blue2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "blue";
        }
        else if (!inventory4)
        {
            Blue3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "blue";
        }
    }
    public void GreenPickup()
    {
        if (!inventory1)
        {
            Green.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "green";
        }
        else if (!inventory2)
        {
            Green1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "green";
        }
        else if (!inventory3)
        {
            Green2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "green";
        }
        else if (!inventory4)
        {
            Green3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "green";
        }
    }
    public void YellowPickup()
    {
        if (!inventory1)
        {
            Yellow.SetActive(true);
            inventory1 = true;
            inventorycounter += 1;
            inventoryitem1 = "yellow";
        }
        else if (!inventory2)
        {
            Yellow1.SetActive(true);
            inventory2 = true;
            inventorycounter += 1;
            inventoryitem2 = "yellow";
        }
        else if (!inventory3)
        {
            Yellow2.SetActive(true);
            inventory3 = true;
            inventorycounter += 1;
            inventoryitem3 = "yellow";
        }
        else if (!inventory4)
        {
            Yellow3.SetActive(true);
            inventory4 = true;
            inventorycounter += 1;
            inventoryitem4 = "yellow";
        }
    }
    public void Hotbar1()
    {
        switch (inventoryitem1)
        {
            case "purple":
                Purple.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(purple1, player.position, player.rotation);
                break;
            case "blue":
                Blue.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(blue1, player.position, player.rotation);
                break;
            case "yellow":
                Yellow.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(yellow1, player.position, player.rotation);
                break;
            case "green":
                Green.SetActive(false);
                inventory1 = false;
                inventorycounter -= 1;
                Instantiate(green1, player.position, player.rotation);
                break;
        }
 
    }
    public void Hotbar2()
    {
        switch (inventoryitem2)
        {
            case "purple":
                Purple1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(purple1, player.position, player.rotation);
                break;
            case "blue":
                Blue1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(blue1, player.position, player.rotation);
                break;
            case "yellow":
                Yellow1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(yellow1, player.position, player.rotation);
                break;
            case "green":
                Green1.SetActive(false);
                inventory2 = false;
                inventorycounter -= 1;
                Instantiate(green1, player.position, player.rotation);
                break;
        }
    } 
    public void Hotbar3()
    {
            {
                if (inventoryitem3 == "purple" && inventory3)
                {
                    Purple2.SetActive(false);
                    inventory3 = false;
                    inventorycounter -= 1;
                    Instantiate(purple1, player.position, player.rotation);
                }
                else if (inventoryitem3 == "blue" && inventory3)
                {
                    Blue2.SetActive(false);
                    inventory3 = false;
                    inventorycounter -= 1;
                    Instantiate(blue1, player.position, player.rotation);

                }
                else if (inventoryitem3 == "yellow" && inventory3)
                {
                    Yellow2.SetActive(false);
                    inventory3 = false;
                    inventorycounter -= 1;
                    Instantiate(yellow1, player.position, player.rotation);
                }
                else if (inventoryitem3 == "green" && inventory3)
                {
                    Green2.SetActive(false);
                    inventory3 = false;
                    inventorycounter -= 1;
                    Instantiate(green1, player.position, player.rotation);
                }
            }
        }
    public void Hotbar4()
    {
        {
            if (inventoryitem4 == "purple" && inventory4)
            {
                Purple3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(purple1, player.position, player.rotation);

            }
            else if (inventoryitem4 == "blue" && inventory4)
            {
                Blue3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(blue1, player.position, player.rotation);
            }
            else if (inventoryitem4 == "yellow" && inventory4)
            {
                Yellow3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(yellow1, player.position, player.rotation);
            }
            else if (inventoryitem4 == "green" && inventory4)
            {
                Green3.SetActive(false);
                inventory4 = false;
                inventorycounter -= 1;
                Instantiate(green1, player.position, player.rotation);

            }
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

    }
    public void UseItem3()
    {

    }
    public void UseItem4()
    {

    }
}



