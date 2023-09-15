using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x <= -9)
        {
            transform.position = new Vector2(8.95f,transform.position.y);
        }
        if (transform.position.x >= 9)
        {
            transform.position = new Vector2(-8.95f, transform.position.y);
        }
    }
}
