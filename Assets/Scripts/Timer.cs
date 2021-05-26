using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GameController))]
public class Timer : MonoBehaviour
{
    private GameController gameController;
    
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;
    public Text timerText;

    private void Start()
    {
        gameController = GetComponent<GameController>();
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timerText.text = timeRemaining.ToString("00:00");
                timeRemaining -= Time.deltaTime;
            } 
            else
            {
                Debug.Log("Out of time!");
                timerText.text = "00:00";
                timeRemaining = 0;
                timerIsRunning = false;
                gameController.DisplayLoseScreen();
            }
        }

    }
}
