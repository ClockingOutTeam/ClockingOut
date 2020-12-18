using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        //Public variable to store a reference to the player game object
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    [Range(0.01f, 1.0f)]
    public float smoothness; //some game dev friendly variables so they can just adjust the camera rotation through inspector
    public bool lookAtPlayer = true;
    public bool rotateAroundPlayer = true; //some basic bools depending on how we want this to work
    public float rotationSpeed = 5.0f;

    // Using this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.position;
    }
    
    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (rotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);

            //resets offset.
            offset = camTurnAngle * offset;
        }

        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        Vector3 newPos = player.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothness);

        if (lookAtPlayer || rotateAroundPlayer) 
        {
            transform.LookAt(player);
        }
      
    }
}
