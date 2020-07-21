using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    int savedLevel = PlayerPrefs.GetInt("savedLevel");

    public void StartGame()
    {
        if (savedLevel == 0)
        {
            SceneManager.LoadScene(savedLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(savedLevel + 1);
        }
    }

    public void ExitGame()
    {
        Debug.Log("Game quitted");
        Application.Quit();
    }
}
