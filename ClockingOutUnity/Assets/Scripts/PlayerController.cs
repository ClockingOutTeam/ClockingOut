using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float health = 3;
    public float xPause;
    public float yPause;
    public float zPause;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            transform.Translate((input * speed) * Time.deltaTime);

            if(Input.GetKeyDown("W") || Input.GetKeyDown("A") || Input.GetKeyDown("S") || Input.GetKeyDown("D") || Input.GetKeyDown("space"))
            {

            }
    }
}
