using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private GameObject playerRef;
    public GameObject Damage;
    public float speed = 3;

    private bool detectPlayer = false;
    private float detectionRange = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        gameObject.tag = "Damage";
    }

    // Update is called once per frame
    void Update()
    {
        float disToPlayer = (transform.position - playerRef.transform.position).magnitude;

        if (detectPlayer && playerRef != null)
        {
            Vector3 distanceToPlayer = (playerRef.transform.position - transform.position).normalized;
            speed = 4;

            transform.forward = distanceToPlayer;
            transform.position += distanceToPlayer * speed * Time.deltaTime;

            if(disToPlayer > detectionRange)
            {
                detectPlayer = false;
            }
        }
        else
        {
            if(disToPlayer <= detectionRange)
            {
                detectPlayer = true;
            }
        }
    }
}
