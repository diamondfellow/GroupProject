using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorywood : MonoBehaviour
{
    public static bool wood = false;
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && PlayerPickup.hasCrowbar)
        {
            gameObject.SetActive(false);
            wood = true;
        }
    }
}
