using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneHandler : MonoBehaviour
{
    public Image fade;
    //scorescript
    private void Start()
    {
        //text = scorescript.score.tostring();
    }
    public void StartGame()
    {
        StartCoroutine(StartGameAfter());
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator StartGameAfter()
    {
        fade.CrossFadeAlpha(255, 2, true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameScene");
    }
}
