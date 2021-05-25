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
    }

    public void DisplayWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void DisplayLoseScreen()
    {
        loseScreen.SetActive(true);
    }
    
}
