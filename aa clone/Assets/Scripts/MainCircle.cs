using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour
{
    public GameObject smallCircle;
    GameObject gameBrain;
    void Start()
    {
        gameBrain = GameObject.FindGameObjectWithTag("GameOverTag");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SmallCircleSpawn();
        }
    }

    void SmallCircleSpawn()
    {
        Instantiate(smallCircle, transform.position, transform.rotation);
        gameBrain.GetComponent<CheckGameOver>().ShowTextOnMainCircles();
    }

}
