﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircle : MonoBehaviour
{
    Rigidbody2D physics;
    public float speed;
    bool collisionControl = false;
    GameObject gameOverObject;
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        gameOverObject = GameObject.FindGameObjectWithTag("GameOverTag");
    }
    void FixedUpdate()
    {
        if (!collisionControl)
        {
            physics.MovePosition(physics.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 scale = gameOverObject.transform.localScale;

        if (collision.CompareTag("RotatingCircleTag"))
        {
            transform.SetParent(collision.transform);
            //GameObject.FindGameObjectWithTag("SmallCircleTag").transform.parent = collision.transform;
            //GameObject.FindGameObjectWithTag("SmallCircleTag").transform.localScale = scale;
            collisionControl = true;
        }
        if (collision.CompareTag("SmallCircleTag"))
        {
            gameOverObject.GetComponent<CheckGameOver>().GameOver();
        }
    }
}
