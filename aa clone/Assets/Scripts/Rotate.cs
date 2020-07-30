using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour
{
    public float speed;
    GameObject rotatingCircle;
    Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    //bool isRotationClockwise = true;

    //private void Start()
    //{
    //    if (SceneManager.GetActiveScene().name == "7" || SceneManager.GetActiveScene().name == "8")
    //    {
    //        InvokeRepeating("ChangeRotation", 5, 5);
    //        StartCoroutine(RotationChange());
    //    }
    //}


    void Update()
    {
        if (int.Parse(SceneManager.GetActiveScene().name) <= 4)
        {
            // Levels that are smaller than 4 rotates counter clockwise.
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        if (SceneManager.GetActiveScene().name == "5" || SceneManager.GetActiveScene().name == "6")
        {
            // Levels that are bigger than 5 rotates clockwise.
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }

        if (SceneManager.GetActiveScene().name == "7" || SceneManager.GetActiveScene().name == "8")
        {
            transform.Rotate(0, 0, -speed * Time.deltaTime);

            //if (isRotationClockwise)
            //{
            //    StartCoroutine(RotationChange());
            //}
        }
    }

    //void ChangeRotation()
    //{
    //    Debug.Log("Change rotation works.");
    //    transform.Rotate(0, 0, speed * Time.deltaTime);
    //}

    //IEnumerator RotationChange()
    //{

    //    Debug.Log("Coroutine works.");
    //    transform.Rotate(0, 0, speed * Time.deltaTime);
    //    isRotationClockwise = false;
    //    yield return null;
    //}
}
