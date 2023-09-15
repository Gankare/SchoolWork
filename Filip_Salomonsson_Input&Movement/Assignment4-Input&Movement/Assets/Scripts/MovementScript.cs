using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float speed = 5f;
    private Vector2 position = new Vector2(0,0);

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            position.y += 1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.y += -1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x += -1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += 1 * speed * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        transform.position = position;
    }
}
