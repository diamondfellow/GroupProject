using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoOutside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sylvia.LeaveTown == true)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
