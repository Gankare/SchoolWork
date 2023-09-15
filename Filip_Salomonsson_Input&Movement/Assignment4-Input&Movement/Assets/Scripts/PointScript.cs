using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mike")
        {
           PointSpawningScript.mikeScore += 1;
            Destroy(gameObject);

        }
        else if (other.tag == "Sully")
        {
            PointSpawningScript.sullyScore += 1;
            Destroy(gameObject);
        }
    }
}
