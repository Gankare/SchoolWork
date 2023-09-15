using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointSpawningScript : MonoBehaviour
{
    private float timer;
    public GameObject capsule;
    public static float mikeScore = 0;
    public static float sullyScore = 0;
    public TMPro.TMP_Text sullyScoreText;
    public TMPro.TMP_Text mikeScoreText;

    void Update()
    {
        sullyScoreText.text = "Score: " + sullyScore.ToString();
        mikeScoreText.text = "Score: " + mikeScore.ToString();
        timer += Time.deltaTime;

        if (timer >= 1)
        { 
            Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(capsule, randomPositionOnScreen, Quaternion.identity);
            timer = 0;
        }
    }
}
