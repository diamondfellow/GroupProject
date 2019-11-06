using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uSE : MonoBehaviour
{
    public static bool isUsing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isUsing = true;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            isUsing = false;
        }
    }
}
