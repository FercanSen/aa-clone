using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircleScript : MonoBehaviour
{
    Rigidbody2D physics;
    public float speed;
    bool collisionControl = false;

    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
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
        if (collision.tag == "RotatingCircleTag")
        {
            transform.SetParent(collision.transform);
            collisionControl = true;
        }
    }
}
