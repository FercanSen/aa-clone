using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("1");
    }

    public void ExitGame()
    {
        Debug.Log("Game quitted");
        Application.Quit();
    }
}
