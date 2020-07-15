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
    public Text rotatingCircleLevel;
    public Text firstMainCircle;
    public Text secondMainCircle;
    public Text thirdMainCircle;

    void Start()
    {
        rotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircleTag");
        mainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
        rotatingCircleLevel.text = SceneManager.GetActiveScene().name;
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
