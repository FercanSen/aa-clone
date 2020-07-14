using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    GameObject rotatingCircle;
    GameObject mainCircle;
    void Start()
    {
        rotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircleTag");
        mainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
    }

    public void GameOver()
    {
        rotatingCircle.GetComponent<Rotate>().enabled = false;
        mainCircle.GetComponent<MainCircleScript>().enabled = false;
    }
}
