using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (int.Parse(SceneManager.GetActiveScene().name) <= 4 || (int.Parse(SceneManager.GetActiveScene().name) >= 7 && int.Parse(SceneManager.GetActiveScene().name) < 9))
        {
            // Levels that are smaller than 4 and also level 7 and 8 rotates clockwise.
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        if ((int.Parse(SceneManager.GetActiveScene().name) >= 5 && int.Parse(SceneManager.GetActiveScene().name) < 7) || int.Parse(SceneManager.GetActiveScene().name) >= 9)
        {
            // Levels that are bigger than 5 and also level 8 and 9 rotates counter clockwise.
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }
}
