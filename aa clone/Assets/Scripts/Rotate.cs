using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour
{
    public float speed;

    

    // Update is called once per frame
    void Update()
    {

        float angle = transform.localEulerAngles.z;
        angle = (angle > 180) ? angle - 360 : angle;

        if (int.Parse(SceneManager.GetActiveScene().name) <= 4)
        {
            //Debug.Log("Level is less than or equal to four");
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
        if (int.Parse(SceneManager.GetActiveScene().name) >= 5)
        {
            //Debug.Log("Level is more than five.");
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }
}
