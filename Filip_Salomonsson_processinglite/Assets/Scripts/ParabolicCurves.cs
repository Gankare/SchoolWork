using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurves : ProcessingLite.GP21
{
    private float x;
    private float y;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        Line(0, 0, 0, Height);
        Line(0, 0, Width, 0);
        x = Width * 0.05f;
        y = Height * 0.95f;
    }

    // Update is called once per frame
    void Update()
    { 
        for(int i = 0; i < Width; i++)
        {
            counter++;
            if (counter % 3 == 0)
            {
                Stroke(255, 0, 128);
                counter = 0;
            }
            else Stroke(255, 255, 255);
            Line(0,y,x,0);
            x += Width * 0.05f;
            y -= Height * 0.05f;
        }
    }
}
