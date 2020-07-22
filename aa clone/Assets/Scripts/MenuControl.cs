using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{


    public void StartGame()
    {
        int savedLevel = PlayerPrefs.GetInt("savedLevel");

        if (savedLevel == 0)
        {
            SceneManager.LoadScene(savedLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(savedLevel);
        }
    }

    public void ExitGame()
    {
        Debug.Log("Game quitted");
        Application.Quit();
    }
}
