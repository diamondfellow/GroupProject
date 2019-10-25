using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPickup : MonoBehaviour
{
    public TextController textController;
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
        if(collision.gameObject.tag == "Text1" && Input.GetKeyDown(KeyCode.E))
        {
            textController.Text1();
        }
    }
}
