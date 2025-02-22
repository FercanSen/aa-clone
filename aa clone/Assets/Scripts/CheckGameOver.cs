﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckGameOver : MonoBehaviour
{
    GameObject rotatingCircle;
    GameObject mainCircle;
    public Animator animator;
    public Text currentLevel;
    public Text firstMainCircle;
    public Text secondMainCircle;
    public Text thirdMainCircle;
    public int totalSmallCircleCount;
    bool gameOverControl = false;

    void Start()
    {
        PlayerPrefs.SetInt("savedLevel", int.Parse(SceneManager.GetActiveScene().name)); // Save the current level's name as integer to load later.

        rotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircleTag");
        mainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
        currentLevel.text = SceneManager.GetActiveScene().name;

        if (totalSmallCircleCount < 2)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = "";
            thirdMainCircle.text = "";
        }
        else if (totalSmallCircleCount < 3)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
            thirdMainCircle.text = "";
        }
        else
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
            thirdMainCircle.text = (totalSmallCircleCount - 2).ToString();
        }
    }


    public void ShowTextOnMainCircles()
    {
        totalSmallCircleCount--;

        if (totalSmallCircleCount < 2)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = "";
            thirdMainCircle.text = "";
        }
        else if (totalSmallCircleCount < 3)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
            thirdMainCircle.text = "";
        }
        else
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
            thirdMainCircle.text = (totalSmallCircleCount - 2).ToString();
        }
        if (totalSmallCircleCount == 0)
        {
            StartCoroutine(NewLevel());
        }
    }

    IEnumerator NewLevel()
    {
        mainCircle.GetComponent<MainCircle>().enabled = false;

        yield return new WaitForSeconds(1.5f);
        if (!gameOverControl)
        {
            animator.SetTrigger("NewLevelTrigger");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);  // Go to next level by current level + 1.
        }
    }

    public void GameOver()
    {

        StartCoroutine(GameOverEnumerator());
        // We need to wait a second to see the animation

        // TODO: Don't go to main menu on game over. Display a "restart" or "try again" button and "return to main menu" button.
    }

    IEnumerator GameOverEnumerator()
    {
        gameOverControl = true;
        rotatingCircle.GetComponent<Rotate>().enabled = false;
        rotatingCircle.GetComponent<Rotate>().StopAllCoroutines();
        if (SceneManager.GetActiveScene().name == "7" || SceneManager.GetActiveScene().name == "8")
        {
            rotatingCircle.GetComponent<Scale>().enabled = false;
        }
        mainCircle.GetComponent<MainCircle>().enabled = false;

        animator.SetTrigger("GameOverTrigger");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("MainMenu");
    }
}
