using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tweek : MonoBehaviour
{
    public float x;
    public float y;
    public float diameter = 0.2f;
    public Vector3 rotator;
    public float speed;
    public float rotateX;
    public float rotateY;
    public float rotateZ;

    void Update()
    {
        transform.Rotate(rotateX,rotateY ,rotateZ);
        transform.position = new Vector3(x, y);
        transform.localScale = new Vector3(diameter, diameter, diameter);

        if (Input.GetKey(KeyCode.W))
        {
            //Rotates Up
            rotateX = 0;
            rotateY = 0;
            rotateZ = 0;
            rotator = Vector3.up;
            transform.Rotate(rotator * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //Rotates Left
            rotateX = 0;
            rotateY = 0;
            rotateZ = 0;
            rotator = Vector3.left;
            transform.Rotate(rotator * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Rotate Down
            rotateX = 0;
            rotateY = 0;
            rotateZ = 0;
            rotator = Vector3.down;
            transform.Rotate(rotator * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotateX = 0;
            rotateY = 0;
            rotateZ = 0;
            rotator = Vector3.right;
            transform.Rotate(rotator * speed * Time.deltaTime);
            //Rotate Right
        }
        else rotator = Vector3.zero;
    }
}
