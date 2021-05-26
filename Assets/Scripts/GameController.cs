using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject winScreen;
    public GameObject loseScreen;

    private void Start()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void DisplayWinScreen()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void DisplayLoseScreen()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    
}
