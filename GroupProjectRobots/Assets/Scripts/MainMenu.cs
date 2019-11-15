using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Name");
        PlayerPrefs.SetString("inventory1", "");
        PlayerPrefs.SetString("inventory2", "");

        PlayerPrefs.SetString("inventory3", "");

        PlayerPrefs.SetString("inventory4", "");
        PlayerPrefs.SetString("Playername", "No Name");

    }
    public void SaveName()
    {
        SceneManager.LoadScene("Town");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
