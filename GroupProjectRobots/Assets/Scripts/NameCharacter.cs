using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameCharacter : MonoBehaviour
{
    string test = "nomameni";
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Playername", test);
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetString("Playername", GetComponent<Text>().text );
        Debug.Log(PlayerPrefs.GetString("Playername"));
    }
}
