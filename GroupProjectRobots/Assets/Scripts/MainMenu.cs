using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Name");
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
