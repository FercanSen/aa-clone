using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour
{
    public float speed;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "9" || SceneManager.GetActiveScene().name == "10")
        {
            StartCoroutine(changableRotation());
        }
    }

    void Update()
    {
        if (int.Parse(SceneManager.GetActiveScene().name) <= 4)
        {
            // Levels that are smaller than 4 rotates counter clockwise.
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        if (int.Parse(SceneManager.GetActiveScene().name) >= 5 && int.Parse(SceneManager.GetActiveScene().name) <= 8)
        {
            // Levels between 5 and 8 rotates clockwise.
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }

    IEnumerator changableRotation()
    {
        float clockwiseTimer = 0;
        clockwiseTimer += Time.deltaTime;
        float lastDigit = clockwiseTimer % 10;

        while (lastDigit <= 4)
        {
            // Rotating circle rotates clockwise for 5 seconds.
            transform.Rotate(0, 0, -speed * Time.deltaTime);
            clockwiseTimer += Time.deltaTime;
            lastDigit = clockwiseTimer % 10;
            yield return null;

        }
        while (lastDigit > 4)
        {
            // And rotates counter clockwise for 5 seconds.
            transform.Rotate(0, 0, speed * Time.deltaTime);
            clockwiseTimer += Time.deltaTime;
            lastDigit = clockwiseTimer % 10;
            yield return null;
        }
        StartCoroutine(changableRotation());
    }
}
