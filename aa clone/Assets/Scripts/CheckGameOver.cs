using System.Collections;
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

    void Start()
    {
        rotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircleTag");
        mainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
        currentLevel.text = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (totalSmallCircleCount < 2)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
        }
        else if (totalSmallCircleCount < 3)
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
        }
        else
        {
            firstMainCircle.text = totalSmallCircleCount.ToString();
            secondMainCircle.text = (totalSmallCircleCount - 1).ToString();
            thirdMainCircle.text = (totalSmallCircleCount - 2).ToString();
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
        rotatingCircle.GetComponent<Rotate>().enabled = false;
        mainCircle.GetComponent<MainCircleScript>().enabled = false;
        animator.SetTrigger("GameOverTrigger");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("MainMenu");
    }
}
