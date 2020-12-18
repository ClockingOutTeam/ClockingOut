﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed = 5;
    public float xPause;
    public float yPause;
    public float zPause;
    public Timer timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = player.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate((input * speed) * Time.deltaTime);

        Vector3 inputRotate = new Vector3(0.0f, Input.GetAxis("horizontalR"), 0.0f);
        transform.Rotate((inputRotate * speed * 10) * Time.deltaTime);
        
        Vector3 inputJump = new Vector3(0.0f, Input.GetAxis("Jump"), 0.0f);
        transform.Translate((inputJump * speed) * Time.deltaTime);

        if (Input.anyKey)
        {
                timer.timerIsRunning = true;
        }

    }

    private void OnTriggerEnter(Collision other)
    {  
        if (other.gameObject.tag == "Damage")
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
