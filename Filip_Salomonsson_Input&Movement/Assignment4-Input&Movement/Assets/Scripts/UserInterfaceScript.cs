using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterfaceScript : MonoBehaviour
{
    public GameObject controllsMenu;
    public GameObject scoreMenu;
    void Start()
    {
        scoreMenu.SetActive(true);
        controllsMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            scoreMenu.SetActive(false);
            controllsMenu.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            scoreMenu.SetActive(true);
            controllsMenu.SetActive(false);
        }
    }
}
