using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class Timer : MonoBehaviour
{
    private GameController gameController;
    
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;

    private void Start()
    {
        gameController = GetComponent<GameController>();
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            Debug.Log(timeRemaining);
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            } 
            else
            {
                Debug.Log("Out of time!");
                gameController.DisplayLoseScreen();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }

    }
}
