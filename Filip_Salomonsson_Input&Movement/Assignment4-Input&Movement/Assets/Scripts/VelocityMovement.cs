using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VelocityMovement : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private float speed = 200;
    private Vector2 velocity;
    public GravityScript gravityScript;
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gravityScript.isGravity) 
        { 
            if (Input.GetKey(KeyCode.W))
            {
                velocity += new Vector2(0, 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                velocity += new Vector2(0, -1);
            }
            else
            {
                velocity = new Vector2(velocity.x, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            velocity += new Vector2(1, 0);
        }
        else
        {
            velocity = new Vector2(0, velocity.y);
        }
    }
    private void FixedUpdate()
    {
        //Debug.Log(rigid2D.velocity.magnitude);

        if (velocity.magnitude > 1)
        {
            velocity.Normalize();
        }
        rigid2D.velocity = velocity * speed * Time.fixedDeltaTime;
    }
}
