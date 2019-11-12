using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityRoomDoor : MonoBehaviour
{
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
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && PlayerPickup.hasKeycard)
        {
            Destroy(gameObject);
            Destroy(scanner);
        }
    }
}
