using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lineR;
    private Vector2 mousePos;
    private Vector2 startMousePos;

    void Start()
    {
        lineR = GetComponent<LineRenderer>();
        lineR.positionCount = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           
        }
        //Draws the line
        if (Input.GetMouseButton(0))
        {
            lineR.positionCount = 2;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineR.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0));
            lineR.SetPosition(1, new Vector3(mousePos.x,mousePos.y, 0));
        }
        //Removes the line
        if (Input.GetMouseButtonUp(0))
        {
            lineR.positionCount = 0;
        }
    }
}
