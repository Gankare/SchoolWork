using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AcceleratorScript : MonoBehaviour
{
    private Vector2 position;
    private Rigidbody2D rigidBody; 
    private Vector2 acceleration;
    private Vector2 velocity;
    private float speed = 500;
    public GravityScript gravityScript;
    //acceleration should change velocity and velocity should always be applied to the "player")
    void Start()
    {
        position = transform.position;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gravityScript.isGravity)
        { 
            if (Input.GetKey(KeyCode.UpArrow))
            {
                acceleration += Vector2.up;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                acceleration += Vector2.down;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            acceleration += Vector2.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            acceleration += Vector2.right;
        }

        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            acceleration = Vector2.zero; //This does nothing - Players acceleration decreases beacause of the drag on the rigidbody
        }   

        //MaxSpeed - but i dont think it ever goes that high when the normalize below limits the speed 
        if(rigidBody.velocity.sqrMagnitude >= 25)
        {
            rigidBody.velocity = Vector2.ClampMagnitude(rigidBody.velocity, 5);
            Debug.Log("max speed");
        }
    }
    private void FixedUpdate()
    {
        if (acceleration.magnitude > 1) 
        {
            acceleration.Normalize();
        }
        velocity = acceleration * speed * Time.fixedDeltaTime;
        rigidBody.AddForce(velocity);
    }
}
