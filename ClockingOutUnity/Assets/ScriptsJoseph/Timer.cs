using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    void Start()
    {

    }
    void Update()
    {
        //this will run as long as the timerIsRunning boolean is true.
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                //subtracts time
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                //this displays to the console tha tthe time has run out.
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}
