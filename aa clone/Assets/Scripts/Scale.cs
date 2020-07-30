using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scale : MonoBehaviour
{

    Vector3 scaleChange = new Vector3(0.05f, 0.05f, 0.05f);

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "7")
        {
            transform.localScale += scaleChange;
            if (transform.localScale.x >= 17)
            {
                // Since all x, y and z values of the scale will be same. We can just check one. I picked x randomly.
                scaleChange = -scaleChange;
            }
            if (transform.localScale.x <= 8)
            {
                scaleChange = -scaleChange;
            }
        }

        if (SceneManager.GetActiveScene().name == "8")
        {

            transform.localScale += scaleChange * 2;
            if (transform.localScale.x >= 17)
            {
                // Since all x, y and z values of the scale will be same. We can just check one. I picked x randomly.
                scaleChange = -scaleChange;
            }
            if (transform.localScale.x <= 8)
            {
                scaleChange = -scaleChange;
            }
        }
    }
}
