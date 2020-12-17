using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    void Start() 
    {
        //this boolean is set to true when the scene is loaded(if this script is on an object)
        timerIsRunning = true;
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
