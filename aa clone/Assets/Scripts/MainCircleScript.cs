using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircleScript : MonoBehaviour
{
    public GameObject smallCircle;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            smallCircleSpawn();
        }
    }

    void smallCircleSpawn()
    {
        Instantiate(smallCircle, transform.position, transform.rotation);
    }
}
