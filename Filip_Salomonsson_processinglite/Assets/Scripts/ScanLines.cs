using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanLines : ProcessingLite.GP21
{
    float spaceBetweenLines = 0.2f;

    void Update()
    {
        //Clear background
        Background(50, 166, 240);

        //Draw our art/stuff, or in this case a rectangle
        Rect(1, 1, 3, 3);

        //Prepare our stroke settings
        Stroke(128, 128, 128, 64);
        StrokeWeight(0.5f);

        //Draw our scan lines
        for (int i = 0; i < Height / spaceBetweenLines; i++)
        {
            //Increase y-cord each time loop run
            float y = i * spaceBetweenLines;

            //Draw a line from left side of screen to the right
            Line(0, y, Width, y);
        }
    }
}
