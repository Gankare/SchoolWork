using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    public Rigidbody2D rb_Mike;
    public Rigidbody2D rb_Sully;
    public bool isGravity;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && !isGravity)
        {
            rb_Mike.gravityScale = 20;
            rb_Sully.gravityScale = 1;
            isGravity = true;
        }
        else if (Input.GetKeyDown(KeyCode.G) && isGravity)
        {
            rb_Mike.gravityScale = 0;
            rb_Sully.gravityScale = 0;
            isGravity = false;
        }
    }
}
