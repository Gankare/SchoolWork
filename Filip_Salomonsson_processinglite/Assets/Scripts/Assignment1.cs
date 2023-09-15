using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Assignment1 : ProcessingLite.GP21
{
    public float x1;
    public float y1;
    public float x2;
    public float y2;
    void Start()
    {

        //F
        Line(2, 7, 2, 3); //F första linje
        Line(2, 7, 4, 7); //F högsta linje 
        Line(2, 5.5f, 4, 5.5f); //F lägsta linje
        //I
        Line(5, 5.5f, 5, 3);//I punkten
        Line(5, 7, 5, 6.8f);//I linjen
        //L
        Line(6, 7, 6, 3); //L första linje
        Line(6, 3, 8, 3);//L nedersta linje
        //I
        Line(9, 5.5f, 9, 3);//I punkten
        Line(9, 7, 9, 6.8f);//I linjen
        //P
        Line(10, 7, 10, 3);//P första Linje
        BeginShape();
        Vertex(10, 7);
        Vertex(10.5f, 6.8f);
        Vertex(10.8f, 6.5f);
        //Vertex(10.8f, 6.2f);
        Vertex(10.8f, 6f);
        Vertex(10.5f, 5.7f);
        Vertex(10, 5.5f);
        EndShape();

        BeginShape();
        Vertex(13, 4);
        Vertex(13.3f, 3.5f);

        Vertex(13.5f, 3.3f);
        Vertex(14, 3.3f);

        Vertex(14.5f, 3.5f);
        Vertex(15, 4);
        EndShape();

        Fill(255, 133, 0);
        DrawFill = true;
        Circle(15, 5, 0.4f);
        Circle(13, 5, 0.2f);


        Fill(0, 255, 0);
        DrawFill = true;
        Circle(13, 5, 1.2f);
        Circle(15, 5, 1);

        Fill(0, 0, 255);
        DrawFill = true;
        //Sroke(0, 0, 255);
        StrokeWeight(0.1f);
        Rect(2, 8, 4, 9);
    }
}