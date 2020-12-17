using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private GameObject playerRef;

    public float speed = 3;

    private bool detectPlayer = false;
    private float detectionRange = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(detectPlayer && playerRef != null)
        {
            Vector3 distanceToPlayer = (playerRef.transform.position - transform.position).normalized;
            speed = 5;

            transform.forward = distanceToPlayer;
            transform.position += distanceToPlayer * speed * Time.deltaTime;
        }
        else
        {

        }
    }
}
