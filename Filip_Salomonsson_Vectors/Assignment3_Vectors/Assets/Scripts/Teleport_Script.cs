using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Teleport_Script : MonoBehaviour
{
    public float maxSpeed;
    private Vector2 mousePos;
    private Vector2 startMousePos;
    private Vector3 endMouse;
    private Vector3 lastVelocity;
    private Rigidbody2D rb2D;
    public ParticleSystem ps;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Debug.Log(rb2D.velocity.magnitude);
        lastVelocity = rb2D.velocity;
        //Transform works better for movement but it did not work for bounceing on walls because there is no velocity, thats why i use addforce instead
        //transform.position -= endMouse * cirlceSpeed * Time.deltaTime;  
        rb2D.AddForce(-endMouse);
        
        if (Input.GetMouseButtonDown(0))
        {
            endMouse = new Vector3(0, 0, 0);
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = startMousePos;
        }
        if (Input.GetMouseButton(0))
        {
            //Stops the circles velocity when clicking
            if (rb2D.velocity.magnitude != 0)
                rb2D.velocity = Vector2.zero;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endMouse = new Vector3(mousePos.x - startMousePos.x, mousePos.y - startMousePos.y, 0);
        }
        //Set limit to speed
        if (rb2D.velocity.sqrMagnitude > maxSpeed * maxSpeed) 
        {
            Debug.Log("To fast");
            //This did not work, it made the ball faster
            //rb2D.velocity.Normalize();
            //rb2D.velocity *= maxSpeed;
            rb2D.velocity = Vector2.ClampMagnitude(rb2D.velocity, maxSpeed); //Clamp is not in all directions ?
        }
    }

    //Makes the ball Bounce and it works but i also tried 2d physical material thats why this is commented-out
    private void OnCollisionEnter2D(Collision2D other)
    {
        //var speed = lastVelocity.magnitude;
        //var direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);
        //rb2D.velocity = direction * Mathf.Max(speed, 0f);
        Instantiate(ps,transform.position, Quaternion.identity); 
    }
}
